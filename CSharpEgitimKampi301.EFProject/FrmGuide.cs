using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmGuide : Form
    {
        public FrmGuide()
        {
            InitializeComponent();
            List();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void List()
        {
            var allGuideTable = db.Guide.ToList();
            dataGridView_Guide.DataSource = allGuideTable;
            dataGridView_Guide.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 75, 75);
            dataGridView_Guide.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 75, 75);
            dataGridView_Guide.DefaultCellStyle.BackColor = Color.FromArgb(75, 75, 75);
            dataGridView_Guide.DefaultCellStyle.ForeColor = Color.White;
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            //EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

            //var allGuideTable = db.Guide.ToList();
            //dataGridView_Guide.DataSource = allGuideTable;

            List();
        }

        private void Add(Guide guide)
        {
            db.Guide.Add(guide);
            db.SaveChanges();
        }

        public bool checkLetter(string value)
        {
            bool check = false;
            foreach (char i in value)
            {
                if (char.IsLetter(i)) { check = true; }
                if (char.IsDigit(i)) { check = false; break; }
                if (char.IsSymbol(i)) { check = false; break; }
                if (char.IsWhiteSpace(i)) { check = false; break; }
                if (char.IsNumber(i)) { check = false; break; }
                if (char.IsPunctuation(i)) { check = false; break; }

            }
            return check;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var rehberAdi = txtbox_RehberAdi.Text;
            var rehberSoyadi = txtbox_RehberSoyadi.Text;
            if ((!string.IsNullOrEmpty(rehberAdi) && checkLetter(rehberAdi)) && (!string.IsNullOrEmpty(rehberSoyadi) && checkLetter(rehberSoyadi)))
            {
                Guide guide = new Guide();
                guide.GuideName = rehberAdi;
                guide.GuideSurname = rehberSoyadi;
                Add(guide);
                txtbox_RehberAdi.Text = string.Empty;
                txtbox_RehberSoyadi.Text = string.Empty;
                List();
            }
            else
            {
                MessageBox.Show("Rehber adı veya soyadı boş bırakılamaz.\nVe Sadece harf içerebilir", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //int id;
            //if (int.TryParse(txtbox_RehberId.Text, out id)) {
            //    // id ile guide entity elde ediyoruz.
            //    var guide = db.Guide.Find(id);

            //    // Bu arkadaş silmek için bir entity istiyor.
            //    db.Guide.Remove(guide);
            //    db.SaveChanges();
            //    List();
            //}

            try
            {
                var answer = MessageBox.Show("Doğru kişiyi seçtiğinizden emin misiniz?", "Kişi Seçimi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    int rowindex = dataGridView_Guide.CurrentCell.RowIndex;
                    var id = dataGridView_Guide.Rows[rowindex].Cells["GuideId"].Value;
                    var guide = db.Guide.Find(id);
                    db.Guide.Remove(guide);
                    db.SaveChanges();
                    List();
                }

            }
            catch (System.NullReferenceException exception)
            {
                MessageBox.Show("Lütfen listeden bir isim seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(txtbox_RehberId.Text);
            //var guide = db.Guide.Find(id);
            //guide.GuideName = txtbox_RehberAdi.Text;
            //guide.GuideSurname = txtbox_RehberSoyadi.Text;           
            //db.SaveChanges();
            //List();

            var answer = MessageBox.Show("Doğru kişiyi seçtiğinizden emin misiniz?", "Kişi Seçimi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                int rowindex = dataGridView_Guide.CurrentCell.RowIndex;
                var id = dataGridView_Guide.Rows[rowindex].Cells["GuideId"].Value;
                var guide = db.Guide.Find(id);
                guide.GuideName = txtbox_RehberAdi.Text;
                guide.GuideSurname = txtbox_RehberSoyadi.Text;
                db.SaveChanges();
                List();
            }


        }

        private void btn_GetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbox_RehberId.Text);
            var values = db.Guide.Where(x => x.GuideId == id).ToList();
            dataGridView_Guide.DataSource = values;
        }

        public void FrmGuide_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
        }
    }
}
