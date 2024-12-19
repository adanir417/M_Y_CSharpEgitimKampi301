namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmProduct
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
            this.dataGridView_Product = new System.Windows.Forms.DataGridView();
            this.btn_GetByID = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_List = new System.Windows.Forms.Button();
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.textBox_ProductID = new System.Windows.Forms.TextBox();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_ProductID = new System.Windows.Forms.Label();
            this.textBox_ProductStock = new System.Windows.Forms.TextBox();
            this.lbl_ProductStock = new System.Windows.Forms.Label();
            this.textBox_ProductPrice = new System.Windows.Forms.TextBox();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.textBox_ProductDescription = new System.Windows.Forms.TextBox();
            this.lbl_ProductDescription = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.comboBox_ProductCategory = new System.Windows.Forms.ComboBox();
            this.button_ListProduct2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Product
            // 
            this.dataGridView_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Product.Location = new System.Drawing.Point(298, 12);
            this.dataGridView_Product.Name = "dataGridView_Product";
            this.dataGridView_Product.Size = new System.Drawing.Size(954, 996);
            this.dataGridView_Product.TabIndex = 24;
            // 
            // btn_GetByID
            // 
            this.btn_GetByID.Location = new System.Drawing.Point(99, 490);
            this.btn_GetByID.Name = "btn_GetByID";
            this.btn_GetByID.Size = new System.Drawing.Size(165, 30);
            this.btn_GetByID.TabIndex = 23;
            this.btn_GetByID.Text = "ID\'e göre getir";
            this.btn_GetByID.UseVisualStyleBackColor = true;
            this.btn_GetByID.Click += new System.EventHandler(this.btn_GetByID_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(99, 456);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(165, 30);
            this.btn_Update.TabIndex = 22;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(99, 422);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(165, 30);
            this.btn_Delete.TabIndex = 21;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(99, 388);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(165, 30);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_List
            // 
            this.btn_List.Location = new System.Drawing.Point(99, 354);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(60, 30);
            this.btn_List.TabIndex = 19;
            this.btn_List.Text = "Listele";
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.Location = new System.Drawing.Point(99, 59);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(165, 20);
            this.textBox_ProductName.TabIndex = 18;
            // 
            // textBox_ProductID
            // 
            this.textBox_ProductID.Location = new System.Drawing.Point(99, 26);
            this.textBox_ProductID.Name = "textBox_ProductID";
            this.textBox_ProductID.Size = new System.Drawing.Size(165, 20);
            this.textBox_ProductID.TabIndex = 17;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(42, 66);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(51, 13);
            this.lbl_ProductName.TabIndex = 15;
            this.lbl_ProductName.Text = "Ürün Adı:";
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Location = new System.Drawing.Point(46, 33);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(47, 13);
            this.lbl_ProductID.TabIndex = 14;
            this.lbl_ProductID.Text = "Ürün ID:";
            // 
            // textBox_ProductStock
            // 
            this.textBox_ProductStock.Location = new System.Drawing.Point(99, 92);
            this.textBox_ProductStock.Name = "textBox_ProductStock";
            this.textBox_ProductStock.Size = new System.Drawing.Size(165, 20);
            this.textBox_ProductStock.TabIndex = 28;
            // 
            // lbl_ProductStock
            // 
            this.lbl_ProductStock.AutoSize = true;
            this.lbl_ProductStock.Location = new System.Drawing.Point(35, 99);
            this.lbl_ProductStock.Name = "lbl_ProductStock";
            this.lbl_ProductStock.Size = new System.Drawing.Size(58, 13);
            this.lbl_ProductStock.TabIndex = 27;
            this.lbl_ProductStock.Text = "Ürün Stok:";
            // 
            // textBox_ProductPrice
            // 
            this.textBox_ProductPrice.Location = new System.Drawing.Point(99, 125);
            this.textBox_ProductPrice.Name = "textBox_ProductPrice";
            this.textBox_ProductPrice.Size = new System.Drawing.Size(165, 20);
            this.textBox_ProductPrice.TabIndex = 30;
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Location = new System.Drawing.Point(35, 132);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(58, 13);
            this.lbl_ProductPrice.TabIndex = 29;
            this.lbl_ProductPrice.Text = "Ürün Fiyat:";
            // 
            // textBox_ProductDescription
            // 
            this.textBox_ProductDescription.Location = new System.Drawing.Point(99, 181);
            this.textBox_ProductDescription.Multiline = true;
            this.textBox_ProductDescription.Name = "textBox_ProductDescription";
            this.textBox_ProductDescription.Size = new System.Drawing.Size(165, 148);
            this.textBox_ProductDescription.TabIndex = 32;
            // 
            // lbl_ProductDescription
            // 
            this.lbl_ProductDescription.AutoSize = true;
            this.lbl_ProductDescription.Location = new System.Drawing.Point(14, 184);
            this.lbl_ProductDescription.Name = "lbl_ProductDescription";
            this.lbl_ProductDescription.Size = new System.Drawing.Size(79, 13);
            this.lbl_ProductDescription.TabIndex = 31;
            this.lbl_ProductDescription.Text = "Ürün Açıklama:";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(44, 157);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(49, 13);
            this.lbl_Category.TabIndex = 33;
            this.lbl_Category.Text = "Kategori:";
            // 
            // comboBox_ProductCategory
            // 
            this.comboBox_ProductCategory.FormattingEnabled = true;
            this.comboBox_ProductCategory.Location = new System.Drawing.Point(99, 154);
            this.comboBox_ProductCategory.Name = "comboBox_ProductCategory";
            this.comboBox_ProductCategory.Size = new System.Drawing.Size(165, 21);
            this.comboBox_ProductCategory.TabIndex = 34;
            // 
            // button_ListProduct2
            // 
            this.button_ListProduct2.Location = new System.Drawing.Point(204, 352);
            this.button_ListProduct2.Name = "button_ListProduct2";
            this.button_ListProduct2.Size = new System.Drawing.Size(60, 30);
            this.button_ListProduct2.TabIndex = 35;
            this.button_ListProduct2.Text = "Listele2";
            this.button_ListProduct2.UseVisualStyleBackColor = true;
            this.button_ListProduct2.Click += new System.EventHandler(this.button_ListProduct2_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1264, 1031);
            this.Controls.Add(this.button_ListProduct2);
            this.Controls.Add(this.comboBox_ProductCategory);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.textBox_ProductDescription);
            this.Controls.Add(this.lbl_ProductDescription);
            this.Controls.Add(this.textBox_ProductPrice);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.textBox_ProductStock);
            this.Controls.Add(this.lbl_ProductStock);
            this.Controls.Add(this.dataGridView_Product);
            this.Controls.Add(this.btn_GetByID);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.textBox_ProductName);
            this.Controls.Add(this.textBox_ProductID);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_ProductID);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Product;
        private System.Windows.Forms.Button btn_GetByID;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.TextBox textBox_ProductName;
        private System.Windows.Forms.TextBox textBox_ProductID;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ProductID;
        private System.Windows.Forms.TextBox textBox_ProductStock;
        private System.Windows.Forms.Label lbl_ProductStock;
        private System.Windows.Forms.TextBox textBox_ProductPrice;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.TextBox textBox_ProductDescription;
        private System.Windows.Forms.Label lbl_ProductDescription;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.ComboBox comboBox_ProductCategory;
        private System.Windows.Forms.Button button_ListProduct2;
    }
}