using BikeManager.BikestoreModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BikeManager.Controls
{
    public partial class AddProduct : Form
    {
        public Product NewProduct { get; private set; } = null!;


        public AddProduct()
        {
            InitializeComponent();
            Load += AddProduct_Load;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += (s, e) => this.Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            using var context = new se_bikestoreContext();

            comboBoxBrand.DataSource = context.Brands.ToList();
            comboBoxBrand.DisplayMember = "BrandName";
            comboBoxBrand.ValueMember = "BrandSk";

            comboBoxCategory.DataSource = context.Categories.ToList();
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategorySk";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product name is required.");
                return;
            }

            NewProduct = new Product
            {
                ProductName = txtProductName.Text.Trim(),
                BrandId = (int)(comboBoxBrand.SelectedValue ?? 0),
                CategoryFk = (int)(comboBoxCategory.SelectedValue ?? 0),
                ModelYear = (short)numericModelYear.Value,
                ListPrice = numericListPrice.Value
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
