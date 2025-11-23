namespace BikeManager.Controls
{
    partial class AddProduct
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtProductName;
        private ComboBox comboBoxBrand;
        private ComboBox comboBoxCategory;
        private NumericUpDown numericModelYear;
        private NumericUpDown numericListPrice;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtProductName = new TextBox();
            comboBoxBrand = new ComboBox();
            comboBoxCategory = new ComboBox();
            numericModelYear = new NumericUpDown();
            numericListPrice = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();

            ((System.ComponentModel.ISupportInitialize)numericModelYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericListPrice).BeginInit();
            SuspendLayout();

            // txtProductName
            txtProductName.Location = new Point(12, 29);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(200, 23);

            // comboBoxBrand
            comboBoxBrand.Location = new Point(12, 75);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(200, 23);

            // comboBoxCategory
            comboBoxCategory.Location = new Point(12, 121);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(200, 23);

            // numericModelYear
            numericModelYear.Location = new Point(12, 167);
            numericModelYear.Maximum = 3000;
            numericModelYear.Minimum = 2000;
            numericModelYear.Value = 2023;
            numericModelYear.Name = "numericModelYear";
            numericModelYear.Size = new Size(200, 23);

            // numericListPrice
            numericListPrice.Location = new Point(12, 213);
            numericListPrice.Maximum = 1000000;
            numericListPrice.DecimalPlaces = 2;
            numericListPrice.Name = "numericListPrice";
            numericListPrice.Size = new Size(200, 23);

            // btnSave
            btnSave.Location = new Point(12, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 30);
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;

            // btnCancel
            btnCancel.Location = new Point(122, 250);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 30);
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;

            // label1
            label1.Text = "Product Name";
            label1.Location = new Point(12, 10);

            // label2
            label2.Text = "Brand";
            label2.Location = new Point(12, 56);

            // label3
            label3.Text = "Category";
            label3.Location = new Point(12, 102);

            // label4
            label4.Text = "Model Year";
            label4.Location = new Point(12, 148);

            // label5
            label5.Text = "List Price";
            label5.Location = new Point(12, 194);

            // Form Settings
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 300);
            Controls.Add(txtProductName);
            Controls.Add(comboBoxBrand);
            Controls.Add(comboBoxCategory);
            Controls.Add(numericModelYear);
            Controls.Add(numericListPrice);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Name = "AddProduct";
            Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)numericModelYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericListPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
