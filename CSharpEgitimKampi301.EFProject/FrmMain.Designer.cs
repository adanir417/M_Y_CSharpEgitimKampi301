namespace CSharpEgitimKampi301.EFProject
{
    partial class FrmMain
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
            this.btn_GuideForm = new System.Windows.Forms.Button();
            this.btn_LocationForm = new System.Windows.Forms.Button();
            this.btn_StatisticForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GuideForm
            // 
            this.btn_GuideForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.btn_GuideForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GuideForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_GuideForm.Location = new System.Drawing.Point(33, 33);
            this.btn_GuideForm.Name = "btn_GuideForm";
            this.btn_GuideForm.Size = new System.Drawing.Size(153, 44);
            this.btn_GuideForm.TabIndex = 0;
            this.btn_GuideForm.Text = "Rehber İşlemleri";
            this.btn_GuideForm.UseVisualStyleBackColor = false;
            this.btn_GuideForm.Click += new System.EventHandler(this.btn_GuideForm_Click);
            // 
            // btn_LocationForm
            // 
            this.btn_LocationForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btn_LocationForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LocationForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_LocationForm.Location = new System.Drawing.Point(214, 33);
            this.btn_LocationForm.Name = "btn_LocationForm";
            this.btn_LocationForm.Size = new System.Drawing.Size(153, 44);
            this.btn_LocationForm.TabIndex = 1;
            this.btn_LocationForm.Text = "Konum İşlemleri";
            this.btn_LocationForm.UseVisualStyleBackColor = false;
            this.btn_LocationForm.Click += new System.EventHandler(this.btn_LocationForm_Click);
            // 
            // btn_StatisticForm
            // 
            this.btn_StatisticForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btn_StatisticForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StatisticForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_StatisticForm.Location = new System.Drawing.Point(395, 33);
            this.btn_StatisticForm.Name = "btn_StatisticForm";
            this.btn_StatisticForm.Size = new System.Drawing.Size(153, 44);
            this.btn_StatisticForm.TabIndex = 2;
            this.btn_StatisticForm.Text = "İstatistikler";
            this.btn_StatisticForm.UseVisualStyleBackColor = false;
            this.btn_StatisticForm.Click += new System.EventHandler(this.btn_StatisticForm_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_StatisticForm);
            this.Controls.Add(this.btn_LocationForm);
            this.Controls.Add(this.btn_GuideForm);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GuideForm;
        private System.Windows.Forms.Button btn_LocationForm;
        private System.Windows.Forms.Button btn_StatisticForm;
    }
}