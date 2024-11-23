namespace CSharpEgitimKampi301.EFProject
{
    partial class FrmLocation
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
            this.lbl_Location = new System.Windows.Forms.Label();
            this.dataGridView_Location = new System.Windows.Forms.DataGridView();
            this.txtbox_LocationId = new System.Windows.Forms.TextBox();
            this.txtbox_City = new System.Windows.Forms.TextBox();
            this.lbl_City = new System.Windows.Forms.Label();
            this.txtbox_Country = new System.Windows.Forms.TextBox();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_Capacity = new System.Windows.Forms.Label();
            this.txtbox_Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txtbox_DayNight = new System.Windows.Forms.TextBox();
            this.lbl_DayNight = new System.Windows.Forms.Label();
            this.numericUpDown_Capacity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Guide = new System.Windows.Forms.ComboBox();
            this.btn_List = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_GetById = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Location)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Capacity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(28, 23);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(55, 13);
            this.lbl_Location.TabIndex = 0;
            this.lbl_Location.Text = "Konum Id:";
            // 
            // dataGridView_Location
            // 
            this.dataGridView_Location.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Location.Location = new System.Drawing.Point(354, 12);
            this.dataGridView_Location.Name = "dataGridView_Location";
            this.dataGridView_Location.Size = new System.Drawing.Size(900, 700);
            this.dataGridView_Location.TabIndex = 1;
            // 
            // txtbox_LocationId
            // 
            this.txtbox_LocationId.Location = new System.Drawing.Point(86, 17);
            this.txtbox_LocationId.Name = "txtbox_LocationId";
            this.txtbox_LocationId.Size = new System.Drawing.Size(262, 20);
            this.txtbox_LocationId.TabIndex = 2;
            // 
            // txtbox_City
            // 
            this.txtbox_City.Location = new System.Drawing.Point(86, 50);
            this.txtbox_City.Name = "txtbox_City";
            this.txtbox_City.Size = new System.Drawing.Size(262, 20);
            this.txtbox_City.TabIndex = 4;
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(49, 54);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(34, 13);
            this.lbl_City.TabIndex = 3;
            this.lbl_City.Text = "Şehir:";
            // 
            // txtbox_Country
            // 
            this.txtbox_Country.Location = new System.Drawing.Point(86, 83);
            this.txtbox_Country.Name = "txtbox_Country";
            this.txtbox_Country.Size = new System.Drawing.Size(262, 20);
            this.txtbox_Country.TabIndex = 6;
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Location = new System.Drawing.Point(51, 85);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(32, 13);
            this.lbl_Country.TabIndex = 5;
            this.lbl_Country.Text = "Ülke:";
            // 
            // lbl_Capacity
            // 
            this.lbl_Capacity.AutoSize = true;
            this.lbl_Capacity.Location = new System.Drawing.Point(35, 118);
            this.lbl_Capacity.Name = "lbl_Capacity";
            this.lbl_Capacity.Size = new System.Drawing.Size(48, 13);
            this.lbl_Capacity.TabIndex = 7;
            this.lbl_Capacity.Text = "Kapasite";
            // 
            // txtbox_Price
            // 
            this.txtbox_Price.Location = new System.Drawing.Point(86, 149);
            this.txtbox_Price.Name = "txtbox_Price";
            this.txtbox_Price.Size = new System.Drawing.Size(262, 20);
            this.txtbox_Price.TabIndex = 10;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(51, 152);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(32, 13);
            this.lbl_Price.TabIndex = 9;
            this.lbl_Price.Text = "Fiyat:";
            // 
            // txtbox_DayNight
            // 
            this.txtbox_DayNight.Location = new System.Drawing.Point(86, 182);
            this.txtbox_DayNight.Name = "txtbox_DayNight";
            this.txtbox_DayNight.Size = new System.Drawing.Size(262, 20);
            this.txtbox_DayNight.TabIndex = 12;
            // 
            // lbl_DayNight
            // 
            this.lbl_DayNight.AutoSize = true;
            this.lbl_DayNight.Location = new System.Drawing.Point(27, 185);
            this.lbl_DayNight.Name = "lbl_DayNight";
            this.lbl_DayNight.Size = new System.Drawing.Size(56, 13);
            this.lbl_DayNight.TabIndex = 11;
            this.lbl_DayNight.Text = "Gün Gece";
            // 
            // numericUpDown_Capacity
            // 
            this.numericUpDown_Capacity.Location = new System.Drawing.Point(86, 116);
            this.numericUpDown_Capacity.Name = "numericUpDown_Capacity";
            this.numericUpDown_Capacity.Size = new System.Drawing.Size(262, 20);
            this.numericUpDown_Capacity.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rehber:";
            // 
            // comboBox_Guide
            // 
            this.comboBox_Guide.FormattingEnabled = true;
            this.comboBox_Guide.Location = new System.Drawing.Point(86, 215);
            this.comboBox_Guide.Name = "comboBox_Guide";
            this.comboBox_Guide.Size = new System.Drawing.Size(262, 21);
            this.comboBox_Guide.TabIndex = 15;
            // 
            // btn_List
            // 
            this.btn_List.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_List.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_List.Location = new System.Drawing.Point(30, 259);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(318, 39);
            this.btn_List.TabIndex = 16;
            this.btn_List.Text = "Listele";
            this.btn_List.UseVisualStyleBackColor = false;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Add.Location = new System.Drawing.Point(30, 323);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(318, 39);
            this.btn_Add.TabIndex = 17;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Delete.Location = new System.Drawing.Point(30, 387);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(318, 39);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Update.Location = new System.Drawing.Point(30, 451);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(318, 39);
            this.btn_Update.TabIndex = 19;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_GetById
            // 
            this.btn_GetById.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_GetById.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetById.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_GetById.Location = new System.Drawing.Point(30, 515);
            this.btn_GetById.Name = "btn_GetById";
            this.btn_GetById.Size = new System.Drawing.Size(318, 39);
            this.btn_GetById.TabIndex = 20;
            this.btn_GetById.Text = "ID\'e göre getir";
            this.btn_GetById.UseVisualStyleBackColor = false;
            this.btn_GetById.Click += new System.EventHandler(this.btn_GetById_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Refresh.Location = new System.Drawing.Point(30, 573);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(318, 39);
            this.btn_Refresh.TabIndex = 21;
            this.btn_Refresh.Text = "Yenile";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 728);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_GetById);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.comboBox_Guide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_Capacity);
            this.Controls.Add(this.txtbox_DayNight);
            this.Controls.Add(this.lbl_DayNight);
            this.Controls.Add(this.txtbox_Price);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Capacity);
            this.Controls.Add(this.txtbox_Country);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.txtbox_City);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.txtbox_LocationId);
            this.Controls.Add(this.dataGridView_Location);
            this.Controls.Add(this.lbl_Location);
            this.Name = "FrmLocation";
            this.Text = "FrmLocation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLocation_FormClosing);
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Location)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Capacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.DataGridView dataGridView_Location;
        private System.Windows.Forms.TextBox txtbox_LocationId;
        private System.Windows.Forms.TextBox txtbox_City;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox txtbox_Country;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_Capacity;
        private System.Windows.Forms.TextBox txtbox_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txtbox_DayNight;
        private System.Windows.Forms.Label lbl_DayNight;
        private System.Windows.Forms.NumericUpDown numericUpDown_Capacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Guide;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_GetById;
        private System.Windows.Forms.Button btn_Refresh;
    }
}