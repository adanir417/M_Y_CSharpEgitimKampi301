namespace CSharpEgitimKampi301.EFProject
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
            this.lbl_RehberId = new System.Windows.Forms.Label();
            this.txtbox_RehberId = new System.Windows.Forms.TextBox();
            this.btn_List = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbox_RehberAdi = new System.Windows.Forms.TextBox();
            this.lbl_RehberAdi = new System.Windows.Forms.Label();
            this.txtbox_RehberSoyadi = new System.Windows.Forms.TextBox();
            this.lbl_RehberSoyadi = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_GetById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_RehberId
            // 
            this.lbl_RehberId.AutoSize = true;
            this.lbl_RehberId.Location = new System.Drawing.Point(35, 28);
            this.lbl_RehberId.Name = "lbl_RehberId";
            this.lbl_RehberId.Size = new System.Drawing.Size(57, 13);
            this.lbl_RehberId.TabIndex = 0;
            this.lbl_RehberId.Text = "Rehber Id:";
            // 
            // txtbox_RehberId
            // 
            this.txtbox_RehberId.Location = new System.Drawing.Point(97, 25);
            this.txtbox_RehberId.Name = "txtbox_RehberId";
            this.txtbox_RehberId.Size = new System.Drawing.Size(182, 20);
            this.txtbox_RehberId.TabIndex = 1;
            // 
            // btn_List
            // 
            this.btn_List.BackColor = System.Drawing.Color.Coral;
            this.btn_List.Location = new System.Drawing.Point(15, 139);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(264, 49);
            this.btn_List.TabIndex = 2;
            this.btn_List.Text = "Listele";
            this.btn_List.UseVisualStyleBackColor = false;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 691);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtbox_RehberAdi
            // 
            this.txtbox_RehberAdi.Location = new System.Drawing.Point(97, 64);
            this.txtbox_RehberAdi.Name = "txtbox_RehberAdi";
            this.txtbox_RehberAdi.Size = new System.Drawing.Size(182, 20);
            this.txtbox_RehberAdi.TabIndex = 5;
            // 
            // lbl_RehberAdi
            // 
            this.lbl_RehberAdi.AutoSize = true;
            this.lbl_RehberAdi.Location = new System.Drawing.Point(29, 67);
            this.lbl_RehberAdi.Name = "lbl_RehberAdi";
            this.lbl_RehberAdi.Size = new System.Drawing.Size(63, 13);
            this.lbl_RehberAdi.TabIndex = 4;
            this.lbl_RehberAdi.Text = "Rehber Adı:";
            // 
            // txtbox_RehberSoyadi
            // 
            this.txtbox_RehberSoyadi.Location = new System.Drawing.Point(97, 103);
            this.txtbox_RehberSoyadi.Name = "txtbox_RehberSoyadi";
            this.txtbox_RehberSoyadi.Size = new System.Drawing.Size(182, 20);
            this.txtbox_RehberSoyadi.TabIndex = 7;
            // 
            // lbl_RehberSoyadi
            // 
            this.lbl_RehberSoyadi.AutoSize = true;
            this.lbl_RehberSoyadi.Location = new System.Drawing.Point(12, 106);
            this.lbl_RehberSoyadi.Name = "lbl_RehberSoyadi";
            this.lbl_RehberSoyadi.Size = new System.Drawing.Size(80, 13);
            this.lbl_RehberSoyadi.TabIndex = 6;
            this.lbl_RehberSoyadi.Text = "Rehber Soyadı:";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Coral;
            this.btn_Add.Location = new System.Drawing.Point(15, 194);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(264, 49);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Coral;
            this.btn_Delete.Location = new System.Drawing.Point(15, 249);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(264, 49);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Coral;
            this.btn_Update.Location = new System.Drawing.Point(15, 304);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(264, 49);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_GetById
            // 
            this.btn_GetById.BackColor = System.Drawing.Color.Coral;
            this.btn_GetById.Location = new System.Drawing.Point(15, 359);
            this.btn_GetById.Name = "btn_GetById";
            this.btn_GetById.Size = new System.Drawing.Size(264, 49);
            this.btn_GetById.TabIndex = 11;
            this.btn_GetById.Text = "ID\'e göre getir";
            this.btn_GetById.UseVisualStyleBackColor = false;
            this.btn_GetById.Click += new System.EventHandler(this.btn_GetById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 728);
            this.Controls.Add(this.btn_GetById);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtbox_RehberSoyadi);
            this.Controls.Add(this.lbl_RehberSoyadi);
            this.Controls.Add(this.txtbox_RehberAdi);
            this.Controls.Add(this.lbl_RehberAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.txtbox_RehberId);
            this.Controls.Add(this.lbl_RehberId);
            this.Name = "Form1";
            this.Text = "Rehber İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RehberId;
        private System.Windows.Forms.TextBox txtbox_RehberId;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbox_RehberAdi;
        private System.Windows.Forms.Label lbl_RehberAdi;
        private System.Windows.Forms.TextBox txtbox_RehberSoyadi;
        private System.Windows.Forms.Label lbl_RehberSoyadi;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_GetById;
    }
}

