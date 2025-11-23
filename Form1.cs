using Microsoft.EntityFrameworkCore;
using ClosedXML.Excel;
using BikeManager.BikestoreModels;
using BikeManager.Controls;
using System.IO;

namespace BikeManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged += (s, ev) => LoadProducts();
            comboBox2.SelectedIndexChanged += (s, ev) => LoadProducts();
            btnSearch.Click += (s, ev) => LoadProducts();
            btnExportCSV.Click += (s, ev) => ExportToCsv();
            btnExportExcel.Click += (s, ev) => ExportToExcel();
            btnAddProduct.Click += (s, ev) => OpenAddProductForm();

            btnAddOrder.Click += btnAddOrder_Click;
            btnRestock.Click += btnRestock_Click;

            LoadBrandAndCategory();
            LoadProducts();
            LoadCustomersAndProducts();
            LoadOrders();
            LoadLowStock();
        }

        private void LoadBrandAndCategory()
        {
            using var context = new se_bikestoreContext();

            comboBox1.DisplayMember = "BrandName";
            comboBox1.ValueMember = "BrandSk";
            comboBox1.DataSource = context.Brands.ToList();

            comboBox2.DisplayMember = "CategoryName";
            comboBox2.ValueMember = "CategorySk";
            comboBox2.DataSource = context.Categories.ToList();
        }

        private void LoadProducts()
        {
            using var context = new se_bikestoreContext();

            int selectedBrand = comboBox1.SelectedValue is int b ? b : 0;
            int selectedCategory = comboBox2.SelectedValue is int c ? c : 0;
            string search = txtSearch.Text.Trim().ToLower();

            var products = context.Products
                .Include(p => p.Brand)
                .Include(p => p.CategoryFkNavigation)
                .Where(p =>
                    (selectedBrand == 0 || p.BrandId == selectedBrand) &&
                    (selectedCategory == 0 || p.CategoryFk == selectedCategory) &&
                    (string.IsNullOrEmpty(search) || p.ProductName.ToLower().Contains(search))
                )
                .Select(p => new
                {
                    p.ProductSk,
                    p.ProductName,
                    Brand = p.Brand.BrandName,
                    Category = p.CategoryFkNavigation.CategoryName,
                    p.ModelYear,
                    p.ListPrice,
                    Stock = context.Stocks.Where(s => s.ProductFk == p.ProductSk).Sum(s => s.Quantity)
                })
                .ToList();

            dataGridView1.DataSource = products;
        }

        private void ExportToCsv()
        {
            if (dataGridView1.DataSource == null) return;

            using var sfd = new SaveFileDialog { Filter = "CSV Files (*.csv)|*.csv" };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            using var writer = new StreamWriter(sfd.FileName);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                writer.Write(dataGridView1.Columns[i].HeaderText);
                if (i < dataGridView1.Columns.Count - 1)
                    writer.Write(";");
            }
            writer.WriteLine();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    writer.Write(row.Cells[i].Value?.ToString());
                    if (i < dataGridView1.Columns.Count - 1)
                        writer.Write(";");
                }
                writer.WriteLine();
            }

            MessageBox.Show("༼ つ ◕_◕ ༽つExported to CSV ༼ つ ◕_◕ ༽つ");
        }

        private void ExportToExcel()
        {
            if (dataGridView1.DataSource == null) return;

            using var sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx" };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Products");

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    worksheet.Cell(i + 2, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
            }

            worksheet.Columns().AdjustToContents();
            workbook.SaveAs(sfd.FileName);
            MessageBox.Show("Exported to Excel ╰(*°▽°*)╯");

        }

        private void OpenAddProductForm()
        {
            var addForm = new AddProduct();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                using var context = new se_bikestoreContext();
                context.Products.Add(addForm.NewProduct);
                context.SaveChanges();
                LoadProducts();
                MessageBox.Show("(☞ﾟヮﾟ)☞Product added☜(ﾟヮﾟ☜)");
            }
        }

        private void LoadCustomersAndProducts()
        {
            using var context = new se_bikestoreContext();
            comboCustomer.DisplayMember = "FullName";
            comboCustomer.ValueMember = "CustomerSk";
            comboCustomer.DataSource = context.Customers
                .Select(c => new { c.CustomerSk, FullName = c.FirstName + " " + c.LastName })
                .ToList();

            comboProduct.DisplayMember = "ProductName";
            comboProduct.ValueMember = "ProductSk";
            comboProduct.DataSource = context.Products.ToList();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            using var context = new se_bikestoreContext();

            int customerId = (int)comboCustomer.SelectedValue;
            int productId = (int)comboProduct.SelectedValue;
            int quantity = (int)numQuantity.Value;

            int defaultStaffId = context.Staffs.Select(s => s.StaffSk).FirstOrDefault();
            if (defaultStaffId == 0)
            {
                MessageBox.Show("No staff found in the database. Please insert a staff first.ಠ_ಠ");
                return;
            }

            int defaultStoreId = context.Stores.Select(s => s.StoreSk).FirstOrDefault();
            if (defaultStoreId == 0)
            {
                MessageBox.Show("No store found in the database. Please insert a store first.(¬_¬ )");
                return;
            }

            var order = new Order
            {
                CustomerFk = customerId,
                OrderDate = DateTime.Now,
                StaffFk = defaultStaffId,
                StoreFk = defaultStoreId
            };
            context.Orders.Add(order);
            context.SaveChanges();

            var item = new OrderItem
            {
                OrderFk = order.OrderSk,
                ProductFk = productId,
                Quantity = quantity,
                ListPrice = context.Products.First(p => p.ProductSk == productId).ListPrice,
                Discount = 0
            };
            context.OrderItems.Add(item);

            var stock = context.Stocks.FirstOrDefault(s => s.ProductFk == productId);
            if (stock != null)
                stock.Quantity -= quantity;

            context.SaveChanges();

            MessageBox.Show("Order created(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧");
            LoadOrders();
            LoadLowStock();
        }


        private void LoadOrders()
        {
            using var context = new se_bikestoreContext();

            var orders = context.Orders
                .Include(o => o.CustomerFkNavigation)
                .Select(o => new
                {
                    o.OrderSk,
                    Customer = o.CustomerFkNavigation.FirstName + " " + o.CustomerFkNavigation.LastName,
                    o.OrderDate
                })
                .ToList();

            dataGridOrders.DataSource = orders;

            if (orders.Count > 0)
            {
                int firstOrderId = orders.First().OrderSk;
                LoadOrderItems(firstOrderId);
            }

            dataGridOrders.SelectionChanged += (s, e) =>
            {
                if (dataGridOrders.CurrentRow != null)
                {
                    int orderId = (int)dataGridOrders.CurrentRow.Cells["OrderSk"].Value;
                    LoadOrderItems(orderId);
                }
            };
        }

        private void LoadOrderItems(int orderId)
        {
            using var context = new se_bikestoreContext();

            var items = context.OrderItems
                .Include(i => i.ProductFkNavigation)
                .Where(i => i.OrderFk == orderId)
                .Select(i => new
                {
                    i.ProductFkNavigation.ProductName,
                    i.Quantity,
                    i.ListPrice,
                    i.Discount
                }).ToList();

            dataGridItems.DataSource = items;
        }

        private void LoadLowStock()
        {
            using var context = new se_bikestoreContext();

            var lowStock = context.Stocks
                .Include(s => s.ProductFkNavigation)
                .Where(s => s.Quantity < 2)
                .Select(s => new
                {
                    ProductFk = s.ProductFk,
                    s.ProductFkNavigation.ProductName,
                    s.Quantity
                }).ToList();

            dataGridLowStock.DataSource = lowStock;

            foreach (DataGridViewRow row in dataGridLowStock.Rows)
            {
                if (row.Cells["Quantity"].Value is int qty && qty < 2)
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (dataGridLowStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to restock.ಠಿ_ಠ");
                return;
            }

            int productId = (int)dataGridLowStock.SelectedRows[0].Cells["ProductFk"].Value;

            using var context = new se_bikestoreContext();
            var stock = context.Stocks.FirstOrDefault(s => s.ProductFk == productId);

            if (stock != null)
            {
                stock.Quantity += 5;
                context.SaveChanges();

                LoadLowStock();
                MessageBox.Show("Item restocked successfully!ㄟ(≧◇≦)ㄏ", "Restockedヾ(⌐■_■)ノ♪", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Could not find the selected stock item.╯︿╰", "Error(⊙ˍ⊙)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
