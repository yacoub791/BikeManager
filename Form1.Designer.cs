namespace BikeManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainTab = new TabControl();
            tabProducts = new TabPage();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            label3 = new Label();
            txtSearch = new TextBox();
            btnAddProduct = new Button();
            btnExportExcel = new Button();
            btnExportCSV = new Button();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            CreateOrder = new TabPage();
            Orders = new TabPage();
            LowStock = new TabPage();
            comboCustomer = new ComboBox();
            comboProduct = new ComboBox();
            numQuantity = new NumericUpDown();
            btnAddOrder = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridOrders = new DataGridView();
            dataGridItems = new DataGridView();
            dataGridLowStock = new DataGridView();
            btnRestock = new Button();
            MainTab.SuspendLayout();
            tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            CreateOrder.SuspendLayout();
            Orders.SuspendLayout();
            LowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridLowStock).BeginInit();
            SuspendLayout();
            // 
            // MainTab
            // 
            MainTab.Controls.Add(tabProducts);
            MainTab.Controls.Add(CreateOrder);
            MainTab.Controls.Add(Orders);
            MainTab.Controls.Add(LowStock);
            MainTab.Location = new Point(12, 12);
            MainTab.Name = "MainTab";
            MainTab.SelectedIndex = 0;
            MainTab.Size = new Size(776, 426);
            MainTab.TabIndex = 0;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(dataGridView1);
            tabProducts.Controls.Add(btnSearch);
            tabProducts.Controls.Add(label3);
            tabProducts.Controls.Add(txtSearch);
            tabProducts.Controls.Add(btnAddProduct);
            tabProducts.Controls.Add(btnExportExcel);
            tabProducts.Controls.Add(btnExportCSV);
            tabProducts.Controls.Add(label2);
            tabProducts.Controls.Add(comboBox2);
            tabProducts.Controls.Add(label1);
            tabProducts.Controls.Add(comboBox1);
            tabProducts.Location = new Point(4, 24);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3);
            tabProducts.Size = new Size(768, 398);
            tabProducts.TabIndex = 0;
            tabProducts.Text = "Products";
            tabProducts.UseVisualStyleBackColor = true;
            
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(756, 344);
            dataGridView1.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(708, 20);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(54, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(605, 3);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 8;
            label3.Text = "Product Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(596, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(106, 23);
            txtSearch.TabIndex = 7;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(484, 19);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(106, 23);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(372, 19);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(106, 23);
            btnExportExcel.TabIndex = 5;
            btnExportExcel.Text = "Export to Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // btnExportCSV
            // 
            btnExportCSV.Location = new Point(260, 19);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(106, 23);
            btnExportCSV.TabIndex = 4;
            btnExportCSV.Text = "Export to CSV";
            btnExportCSV.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 3);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Category";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(133, 19);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 3);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Brand";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // CreateOrder
            // 
            CreateOrder.Controls.Add(label6);
            CreateOrder.Controls.Add(label5);
            CreateOrder.Controls.Add(label4);
            CreateOrder.Controls.Add(btnAddOrder);
            CreateOrder.Controls.Add(numQuantity);
            CreateOrder.Controls.Add(comboProduct);
            CreateOrder.Controls.Add(comboCustomer);
            CreateOrder.Location = new Point(4, 24);
            CreateOrder.Name = "CreateOrder";
            CreateOrder.Padding = new Padding(3);
            CreateOrder.Size = new Size(768, 398);
            CreateOrder.TabIndex = 1;
            CreateOrder.Text = "Create Order";
            CreateOrder.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            Orders.Controls.Add(dataGridItems);
            Orders.Controls.Add(dataGridOrders);
            Orders.Location = new Point(4, 24);
            Orders.Name = "Orders";
            Orders.Padding = new Padding(3);
            Orders.Size = new Size(768, 398);
            Orders.TabIndex = 2;
            Orders.Text = "Orders";
            Orders.UseVisualStyleBackColor = true;
            // 
            // LowStock
            // 
            LowStock.Controls.Add(btnRestock);
            LowStock.Controls.Add(dataGridLowStock);
            LowStock.Location = new Point(4, 24);
            LowStock.Name = "LowStock";
            LowStock.Padding = new Padding(3);
            LowStock.Size = new Size(768, 398);
            LowStock.TabIndex = 3;
            LowStock.Text = "Low Stock";
            LowStock.UseVisualStyleBackColor = true;
            // 
            // comboCustomer
            // 
            comboCustomer.FormattingEnabled = true;
            comboCustomer.Location = new Point(6, 38);
            comboCustomer.Name = "comboCustomer";
            comboCustomer.Size = new Size(121, 23);
            comboCustomer.TabIndex = 0;
            // 
            // comboProduct
            // 
            comboProduct.FormattingEnabled = true;
            comboProduct.Location = new Point(133, 38);
            comboProduct.Name = "comboProduct";
            comboProduct.Size = new Size(121, 23);
            comboProduct.TabIndex = 1;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(260, 39);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 23);
            numQuantity.TabIndex = 2;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(386, 39);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(120, 23);
            btnAddOrder.TabIndex = 3;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 20);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 4;
            label4.Text = "Customer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(133, 20);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 5;
            label5.Text = "Product";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(260, 20);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 6;
            label6.Text = "Quantity";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // dataGridOrders
            // 
            dataGridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrders.Location = new Point(6, 6);
            dataGridOrders.Name = "dataGridOrders";
            dataGridOrders.RowTemplate.Height = 25;
            dataGridOrders.Size = new Size(366, 386);
            dataGridOrders.TabIndex = 0;
            // 
            // dataGridItems
            // 
            dataGridItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItems.Location = new Point(396, 6);
            dataGridItems.Name = "dataGridItems";
            dataGridItems.RowTemplate.Height = 25;
            dataGridItems.Size = new Size(366, 386);
            dataGridItems.TabIndex = 1;
            // 
            // dataGridLowStock
            // 
            dataGridLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLowStock.Location = new Point(6, 6);
            dataGridLowStock.Name = "dataGridLowStock";
            dataGridLowStock.RowTemplate.Height = 25;
            dataGridLowStock.Size = new Size(762, 199);
            dataGridLowStock.TabIndex = 0;
            // 
            // btnRestock
            // 
            btnRestock.Location = new Point(6, 211);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(75, 23);
            btnRestock.TabIndex = 1;
            btnRestock.Text = "Restock";
            btnRestock.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainTab);
            Name = "Form1";
            Text = "Form1";
            MainTab.ResumeLayout(false);
            tabProducts.ResumeLayout(false);
            tabProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            CreateOrder.ResumeLayout(false);
            CreateOrder.PerformLayout();
            Orders.ResumeLayout(false);
            LowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridLowStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTab;
        private TabPage tabProducts;
        private TabPage CreateOrder;
        private TabPage Orders;
        private TabPage LowStock;
        private Button btnExportExcel;
        private Button btnExportCSV;
        private Label label2;
        private ComboBox comboBox2;
        private Label label1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button btnSearch;
        private Label label3;
        private TextBox txtSearch;
        private Button btnAddProduct;
        private Label label4;
        private Button btnAddOrder;
        private NumericUpDown numQuantity;
        private ComboBox comboProduct;
        private ComboBox comboCustomer;
        private Label label6;
        private Label label5;
        private DataGridView dataGridItems;
        private DataGridView dataGridOrders;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnRestock;
        private DataGridView dataGridLowStock;
    }
}