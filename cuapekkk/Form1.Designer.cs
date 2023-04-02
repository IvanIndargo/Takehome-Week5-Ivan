namespace cuapekkk
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.dataGridView_Category = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_All = new System.Windows.Forms.Button();
            this.button_Filter = new System.Windows.Forms.Button();
            this.comboBox_Filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.textBox_namaproduct = new System.Windows.Forms.TextBox();
            this.textBox_Harga = new System.Windows.Forms.TextBox();
            this.textBox_Stock = new System.Windows.Forms.TextBox();
            this.textBox_NamaCategory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_AddProduct = new System.Windows.Forms.Button();
            this.button_EditProduct = new System.Windows.Forms.Button();
            this.button_RemoveProduct = new System.Windows.Forms.Button();
            this.button_AddCategory = new System.Windows.Forms.Button();
            this.button_RemoveCatagory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_product.Location = new System.Drawing.Point(11, 52);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.Size = new System.Drawing.Size(410, 243);
            this.dataGridView_product.TabIndex = 0;
            this.dataGridView_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_product_CellClick);
            this.dataGridView_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_product_CellContentClick);
            // 
            // dataGridView_Category
            // 
            this.dataGridView_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Category.Location = new System.Drawing.Point(448, 52);
            this.dataGridView_Category.Name = "dataGridView_Category";
            this.dataGridView_Category.Size = new System.Drawing.Size(280, 200);
            this.dataGridView_Category.TabIndex = 1;
            this.dataGridView_Category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Category_CellClick);
            this.dataGridView_Category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Category_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product";
            // 
            // button_All
            // 
            this.button_All.Location = new System.Drawing.Point(191, 19);
            this.button_All.Name = "button_All";
            this.button_All.Size = new System.Drawing.Size(58, 19);
            this.button_All.TabIndex = 3;
            this.button_All.Text = "All";
            this.button_All.UseVisualStyleBackColor = true;
            this.button_All.Click += new System.EventHandler(this.button_All_Click);
            // 
            // button_Filter
            // 
            this.button_Filter.Location = new System.Drawing.Point(255, 19);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(54, 19);
            this.button_Filter.TabIndex = 4;
            this.button_Filter.Text = "Filter:";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button_Filter_Click);
            // 
            // comboBox_Filter
            // 
            this.comboBox_Filter.FormattingEnabled = true;
            this.comboBox_Filter.Location = new System.Drawing.Point(315, 20);
            this.comboBox_Filter.Name = "comboBox_Filter";
            this.comboBox_Filter.Size = new System.Drawing.Size(106, 21);
            this.comboBox_Filter.TabIndex = 5;
            this.comboBox_Filter.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Harga:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Stock:";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(74, 362);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(99, 21);
            this.comboBox_Category.TabIndex = 12;
            // 
            // textBox_namaproduct
            // 
            this.textBox_namaproduct.Location = new System.Drawing.Point(74, 332);
            this.textBox_namaproduct.Name = "textBox_namaproduct";
            this.textBox_namaproduct.Size = new System.Drawing.Size(347, 20);
            this.textBox_namaproduct.TabIndex = 13;
            // 
            // textBox_Harga
            // 
            this.textBox_Harga.Location = new System.Drawing.Point(74, 395);
            this.textBox_Harga.Name = "textBox_Harga";
            this.textBox_Harga.Size = new System.Drawing.Size(99, 20);
            this.textBox_Harga.TabIndex = 14;
            this.textBox_Harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Harga_KeyPress);
            // 
            // textBox_Stock
            // 
            this.textBox_Stock.Location = new System.Drawing.Point(74, 425);
            this.textBox_Stock.Name = "textBox_Stock";
            this.textBox_Stock.Size = new System.Drawing.Size(99, 20);
            this.textBox_Stock.TabIndex = 15;
            this.textBox_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Stock_KeyPress);
            // 
            // textBox_NamaCategory
            // 
            this.textBox_NamaCategory.Location = new System.Drawing.Point(489, 279);
            this.textBox_NamaCategory.Name = "textBox_NamaCategory";
            this.textBox_NamaCategory.Size = new System.Drawing.Size(239, 20);
            this.textBox_NamaCategory.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nama:";
            // 
            // button_AddProduct
            // 
            this.button_AddProduct.Location = new System.Drawing.Point(213, 381);
            this.button_AddProduct.Name = "button_AddProduct";
            this.button_AddProduct.Size = new System.Drawing.Size(62, 47);
            this.button_AddProduct.TabIndex = 18;
            this.button_AddProduct.Text = "Add Product";
            this.button_AddProduct.UseVisualStyleBackColor = true;
            this.button_AddProduct.Click += new System.EventHandler(this.button_AddProduct_Click);
            // 
            // button_EditProduct
            // 
            this.button_EditProduct.Location = new System.Drawing.Point(281, 381);
            this.button_EditProduct.Name = "button_EditProduct";
            this.button_EditProduct.Size = new System.Drawing.Size(59, 47);
            this.button_EditProduct.TabIndex = 19;
            this.button_EditProduct.Text = "Edit Product";
            this.button_EditProduct.UseVisualStyleBackColor = true;
            this.button_EditProduct.Click += new System.EventHandler(this.button_EditProduct_Click);
            // 
            // button_RemoveProduct
            // 
            this.button_RemoveProduct.Location = new System.Drawing.Point(346, 381);
            this.button_RemoveProduct.Name = "button_RemoveProduct";
            this.button_RemoveProduct.Size = new System.Drawing.Size(62, 47);
            this.button_RemoveProduct.TabIndex = 20;
            this.button_RemoveProduct.Text = "Remove Product";
            this.button_RemoveProduct.UseVisualStyleBackColor = true;
            this.button_RemoveProduct.Click += new System.EventHandler(this.button_RemoveProduct_Click);
            // 
            // button_AddCategory
            // 
            this.button_AddCategory.Location = new System.Drawing.Point(591, 308);
            this.button_AddCategory.Name = "button_AddCategory";
            this.button_AddCategory.Size = new System.Drawing.Size(62, 40);
            this.button_AddCategory.TabIndex = 21;
            this.button_AddCategory.Text = "Add Category";
            this.button_AddCategory.UseVisualStyleBackColor = true;
            this.button_AddCategory.Click += new System.EventHandler(this.button_AddCategory_Click);
            // 
            // button_RemoveCatagory
            // 
            this.button_RemoveCatagory.Location = new System.Drawing.Point(659, 308);
            this.button_RemoveCatagory.Name = "button_RemoveCatagory";
            this.button_RemoveCatagory.Size = new System.Drawing.Size(62, 40);
            this.button_RemoveCatagory.TabIndex = 22;
            this.button_RemoveCatagory.Text = "Remove Category";
            this.button_RemoveCatagory.UseVisualStyleBackColor = true;
            this.button_RemoveCatagory.Click += new System.EventHandler(this.button_RemoveCatagory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.button_RemoveCatagory);
            this.Controls.Add(this.button_AddCategory);
            this.Controls.Add(this.button_RemoveProduct);
            this.Controls.Add(this.button_EditProduct);
            this.Controls.Add(this.button_AddProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_NamaCategory);
            this.Controls.Add(this.textBox_Stock);
            this.Controls.Add(this.textBox_Harga);
            this.Controls.Add(this.textBox_namaproduct);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Filter);
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.button_All);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Category);
            this.Controls.Add(this.dataGridView_product);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_product;
        private System.Windows.Forms.DataGridView dataGridView_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_All;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.ComboBox comboBox_Filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.TextBox textBox_namaproduct;
        private System.Windows.Forms.TextBox textBox_Harga;
        private System.Windows.Forms.TextBox textBox_Stock;
        private System.Windows.Forms.TextBox textBox_NamaCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_AddProduct;
        private System.Windows.Forms.Button button_EditProduct;
        private System.Windows.Forms.Button button_RemoveProduct;
        private System.Windows.Forms.Button button_AddCategory;
        private System.Windows.Forms.Button button_RemoveCatagory;
    }
}

