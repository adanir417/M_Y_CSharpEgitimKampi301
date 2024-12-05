namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmCategory
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
            this.lbl_CategoryID = new System.Windows.Forms.Label();
            this.lbl_CategoryName = new System.Windows.Forms.Label();
            this.lbl_CategoryStatus = new System.Windows.Forms.Label();
            this.textBox_CategoryID = new System.Windows.Forms.TextBox();
            this.textBox_CategoryName = new System.Windows.Forms.TextBox();
            this.btn_List = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_GetByID = new System.Windows.Forms.Button();
            this.dataGridView_Category = new System.Windows.Forms.DataGridView();
            this.radioButton_CategoryStatusActive = new System.Windows.Forms.RadioButton();
            this.radioButton_CategoryStatusPassive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CategoryID
            // 
            this.lbl_CategoryID.AutoSize = true;
            this.lbl_CategoryID.Location = new System.Drawing.Point(30, 29);
            this.lbl_CategoryID.Name = "lbl_CategoryID";
            this.lbl_CategoryID.Size = new System.Drawing.Size(63, 13);
            this.lbl_CategoryID.TabIndex = 0;
            this.lbl_CategoryID.Text = "Kategori ID:";
            // 
            // lbl_CategoryName
            // 
            this.lbl_CategoryName.AutoSize = true;
            this.lbl_CategoryName.Location = new System.Drawing.Point(26, 70);
            this.lbl_CategoryName.Name = "lbl_CategoryName";
            this.lbl_CategoryName.Size = new System.Drawing.Size(67, 13);
            this.lbl_CategoryName.TabIndex = 1;
            this.lbl_CategoryName.Text = "Kategori Adı:";
            // 
            // lbl_CategoryStatus
            // 
            this.lbl_CategoryStatus.AutoSize = true;
            this.lbl_CategoryStatus.Location = new System.Drawing.Point(10, 110);
            this.lbl_CategoryStatus.Name = "lbl_CategoryStatus";
            this.lbl_CategoryStatus.Size = new System.Drawing.Size(83, 13);
            this.lbl_CategoryStatus.TabIndex = 2;
            this.lbl_CategoryStatus.Text = "Kategori Durum:";
            // 
            // textBox_CategoryID
            // 
            this.textBox_CategoryID.Location = new System.Drawing.Point(99, 26);
            this.textBox_CategoryID.Name = "textBox_CategoryID";
            this.textBox_CategoryID.Size = new System.Drawing.Size(137, 20);
            this.textBox_CategoryID.TabIndex = 3;
            // 
            // textBox_CategoryName
            // 
            this.textBox_CategoryName.Location = new System.Drawing.Point(99, 67);
            this.textBox_CategoryName.Name = "textBox_CategoryName";
            this.textBox_CategoryName.Size = new System.Drawing.Size(137, 20);
            this.textBox_CategoryName.TabIndex = 4;
            // 
            // btn_List
            // 
            this.btn_List.Location = new System.Drawing.Point(99, 153);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(137, 30);
            this.btn_List.TabIndex = 6;
            this.btn_List.Text = "Listele";
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(99, 187);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(137, 30);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(99, 221);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(137, 30);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(99, 255);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(137, 30);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_GetByID
            // 
            this.btn_GetByID.Location = new System.Drawing.Point(99, 289);
            this.btn_GetByID.Name = "btn_GetByID";
            this.btn_GetByID.Size = new System.Drawing.Size(137, 30);
            this.btn_GetByID.TabIndex = 10;
            this.btn_GetByID.Text = "ID\'e göre getir";
            this.btn_GetByID.UseVisualStyleBackColor = true;
            this.btn_GetByID.Click += new System.EventHandler(this.btn_GetByID_Click);
            // 
            // dataGridView_Category
            // 
            this.dataGridView_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Category.Location = new System.Drawing.Point(298, 12);
            this.dataGridView_Category.Name = "dataGridView_Category";
            this.dataGridView_Category.Size = new System.Drawing.Size(497, 426);
            this.dataGridView_Category.TabIndex = 11;
            // 
            // radioButton_CategoryStatusActive
            // 
            this.radioButton_CategoryStatusActive.AutoSize = true;
            this.radioButton_CategoryStatusActive.Location = new System.Drawing.Point(115, 108);
            this.radioButton_CategoryStatusActive.Name = "radioButton_CategoryStatusActive";
            this.radioButton_CategoryStatusActive.Size = new System.Drawing.Size(46, 17);
            this.radioButton_CategoryStatusActive.TabIndex = 12;
            this.radioButton_CategoryStatusActive.TabStop = true;
            this.radioButton_CategoryStatusActive.Text = "Aktif";
            this.radioButton_CategoryStatusActive.UseVisualStyleBackColor = true;
            // 
            // radioButton_CategoryStatusPassive
            // 
            this.radioButton_CategoryStatusPassive.AutoSize = true;
            this.radioButton_CategoryStatusPassive.Location = new System.Drawing.Point(178, 108);
            this.radioButton_CategoryStatusPassive.Name = "radioButton_CategoryStatusPassive";
            this.radioButton_CategoryStatusPassive.Size = new System.Drawing.Size(48, 17);
            this.radioButton_CategoryStatusPassive.TabIndex = 13;
            this.radioButton_CategoryStatusPassive.TabStop = true;
            this.radioButton_CategoryStatusPassive.Text = "Pasif";
            this.radioButton_CategoryStatusPassive.UseVisualStyleBackColor = true;
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton_CategoryStatusPassive);
            this.Controls.Add(this.radioButton_CategoryStatusActive);
            this.Controls.Add(this.dataGridView_Category);
            this.Controls.Add(this.btn_GetByID);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.textBox_CategoryName);
            this.Controls.Add(this.textBox_CategoryID);
            this.Controls.Add(this.lbl_CategoryStatus);
            this.Controls.Add(this.lbl_CategoryName);
            this.Controls.Add(this.lbl_CategoryID);
            this.Name = "FrmCategory";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CategoryID;
        private System.Windows.Forms.Label lbl_CategoryName;
        private System.Windows.Forms.Label lbl_CategoryStatus;
        private System.Windows.Forms.TextBox textBox_CategoryID;
        private System.Windows.Forms.TextBox textBox_CategoryName;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_GetByID;
        private System.Windows.Forms.DataGridView dataGridView_Category;
        private System.Windows.Forms.RadioButton radioButton_CategoryStatusActive;
        private System.Windows.Forms.RadioButton radioButton_CategoryStatusPassive;
    }
}

