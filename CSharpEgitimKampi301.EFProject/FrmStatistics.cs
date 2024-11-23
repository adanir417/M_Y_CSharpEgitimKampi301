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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void FrmStatistics_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            // Toplam Konum Sayısı
            lbl_ValueLocationCount.Text = db.Location.Count().ToString();

            // Toplam Kapasite
            lbl_ValueTotalCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();

            // Rehber Sayısı
            lbl_ValueGuideCount.Text = db.Guide.Count().ToString();

            // Ortalama Tur Kapasitesi
            var formattedAverageCapacity = db.Location.Average(x => x.Capacity);
            lbl_ValueAverageCapacity.Text = $"{formattedAverageCapacity:N0}";

            /*
              
             // Bu yapıya string interpolation adı veriliyor. 
             $"{degiskenADI}"

            // Bu yapı içinde düzelenmek(formatlanmak) istenen yapılar kolaylıkla formatlanabiliyor.

            // Örnek üzerinde N - Number Format uygulanmıştır. Ve Format ifadesinden sonra gelen 0 genellikle virgül sonrası karakteri ifade eder.
            // N2 kullanılsa virgün sonrası 2 karakter gösterecektir.


             */

            // Ortalama Tur Fiyatı
            lbl_ValueAverageLocationPrice.Text = $"{db.Location.Average(x => x.Price):N2} ₺";

            // Eklenen Son Ülke
            //var allLocation = db.Location.ToList();
            //allLocation.Reverse();
            //var lastLocation = allLocation.FirstOrDefault().Country;            
            //lbl_ValueAddedLastCountry.Text = lastLocation;

            var lastId = db.Location.Max(x => x.LocationId);
            lbl_ValueAddedLastCountry.Text = db.Location.Where(x => x.LocationId == lastId).Select(x => x.Country).FirstOrDefault().ToString();


            // Kapadokya Tur Kapasitesi
            lbl_ValueCappadociaCapacity.Text = db.Location.Where(x => x.City.ToLower() == "Kapadokya".ToLower()).Select(x => x.Capacity).FirstOrDefault().ToString();

            // Türkiye Turları Ortalama Kapasite
            lbl_ValueTurkiyeAverageCapacity.Text = $"{db.Location.Where(x => x.Country.ToLower() == "Türkiye".ToLower()).Average(x => x.Capacity):N0}";

            // Türkiye Turları Sayısı
            lbl_ValueTurkiyeCount.Text = db.Location.Where(x => x.Country.ToLower() == "Türkiye".ToLower()).LongCount().ToString();

            // Roma Gezi Rehberi
            var guideId = db.Location.Where(x => x.City.ToLower() == "Roma".ToLower()).Select(x=> x.GuideId).FirstOrDefault();
            lbl_ValueRomeGuideName.Text = db.Guide.Where(x => x.GuideId == guideId).Select(x=> x.GuideName + " " + x.GuideSurname).FirstOrDefault().ToString();


            // En Yüksek Kapasiteli Tur
            var highestCapacity = db.Location.Max(x => x.Capacity);
            lbl_ValueHighestCapacityLocation.Text = db.Location.Where(x => x.Capacity == highestCapacity).Select(x => x.City).FirstOrDefault().ToString() ;


            // En Yüksek Fiyatlı Tur
            var highestPrice = db.Location.Max(y => y.Price);
            lbl_ValueHighestPriceLocation.Text = db.Location.Where(x => x.Price == highestPrice).Select(x => x.City).FirstOrDefault().ToString();

            // Ayşegül ÇINAR'ın Rehberi Olduğu Tur Sayısı
            var aysegulGuideId = db.Guide.Where(x => x.GuideName == "Ayşegül").Select(x => x.GuideId).FirstOrDefault();
            lbl_ValueAysegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == aysegulGuideId).LongCount().ToString();

        }
    }
}
