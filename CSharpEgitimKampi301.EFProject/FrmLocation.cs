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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();

        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        List<Guide> guideList;
        List<GuidePOCO> guidePOCOList;
        List<Location> locationList;
        List<LocationPOCO> locationPOCOList;
        private void btn_List_Click(object sender, EventArgs e)
        {
           
            ShowList();

        }

        private void ShowList() {
            LoadList();
            dataGridView_Location.DataSource = locationPOCOList;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            Refresh();
            ShowList();

        }

        private void Refresh() {
            LoadList();
            comboBox_Guide.DataSource = guidePOCOList;
            comboBox_Guide.ValueMember = "GuideId";
            comboBox_Guide.DisplayMember = "GuideFullName";
            ShowList();
        }


        private LocationPOCO TransferLocationToPOCO(Location location) {
            var locationPoco = new LocationPOCO();
            locationPoco.LocationId = location.LocationId;
            locationPoco.City = location.City;
            locationPoco.Country = location.Country;
            locationPoco.Capacity = location.Capacity;
            locationPoco.Price = location.Price;
            locationPoco.DayNight = location.DayNight;
            var guide = location.Guide;
            locationPoco.GuideId = guide.GuideId;
            locationPoco.GuideNameAndSurname = guide.GuideName + " " + guide.GuideSurname;
            return locationPoco;
        }

        private GuidePOCO TransferGuideToPOCO(Guide guide) {
            var guidePoco = new GuidePOCO();
            guidePoco.GuideId = guide.GuideId;
            guidePoco.GuideName = guide.GuideName;
            guidePoco.GuideSurname = guide.GuideSurname;
            guidePoco.GuideFullName = guide.GuideId.ToString() + " " + guide.GuideName + " " + guide.GuideSurname;
            return guidePoco;
        }

        private void LoadList()
        {
            guideList = new List<Guide>();
            guidePOCOList = new List<GuidePOCO>();
            locationList = new List<Location>();
            locationPOCOList = new List<LocationPOCO>();
            locationList.Clear();
            locationPOCOList.Clear();
            guideList.Clear();
            guidePOCOList.Clear();
            guideList = db.Guide.ToList();

            //var guideList2 = db.Guide.Select(x => new
            //{
            //    FullName = x.GuideName + " " + x.GuideSurname,
            //    x.GuideId

            //}).ToList();
            locationList = db.Location.ToList();
            foreach (var location in locationList)
            {
                locationPOCOList.Add(TransferLocationToPOCO(location));
            }

            foreach (var guide in guideList)
            {
                 guidePOCOList.Add(TransferGuideToPOCO(guide));
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.City = txtbox_City.Text;
            location.Country = txtbox_Country.Text;
            location.Capacity = (byte) numericUpDown_Capacity.Value;
            location.Price = decimal.Parse(txtbox_Price.Text);
            location.DayNight = txtbox_DayNight.Text;           
            location.GuideId = int.Parse(comboBox_Guide.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Konum başarı ile eklendi");
            ShowList();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtbox_LocationId.Text);
            var location = db.Location.Find(id);
            db.Location.Remove(location);
            db.SaveChanges();
            ShowList();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            
            var location = db.Location.Find(int.Parse(txtbox_LocationId.Text));
            location.City = txtbox_City.Text;
            location.Country= txtbox_Country.Text;
            location.Capacity = (byte) numericUpDown_Capacity.Value;
            location.Price = decimal.Parse(txtbox_Price.Text);
            location.DayNight= txtbox_DayNight.Text;
            location.GuideId = int.Parse(comboBox_Guide.SelectedValue.ToString());
            ShowList();
        }

        private void btn_GetById_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtbox_LocationId.Text);
            var withID = db.Location.Where(x => id == x.LocationId).ToList();
            var pocoList = new List<LocationPOCO>();
            foreach (var item in withID) {
                pocoList.Add(TransferLocationToPOCO(item));
            }
            dataGridView_Location.DataSource = pocoList;            
        }

        private void FrmLocation_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
        }
    }
}
