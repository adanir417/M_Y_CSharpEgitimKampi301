## CharpEgitimKampi301.EFProject     
---    
### Entity Framework Çalışmaları.    
Adım adım ders içerisinde yapılanlar:    
1-) Windows Forms App (.Net Framework) Projesi solution içerisine CSharpEgitimKampi301.EFProject adı ile oluşturuldu.    
2-) SQL Server Management Studio ile bu projeye özel bir veritabanı hazırlıyoruz.     
	a-)Sunucuya bağlandıktan sonra Databases üzerine sağ tuş tıklayarak >> New Database... seçeneği ile ilerliyoruz. Veritabanını EgitimKampiEfTravelDb olarak adlandırıyoruz.     
	b-)Oluşan veritabanına gelerek Tables üzerine sağ tuş tıklayarak New >> Tables... seçeneği ile şu tabloları oluşturuyoruz. 
	Tablo adı kayıt esnasında giriliyor.    
|Tablo adı|
|:--:|
Customer

|Column Name|Data Type|Allow Nulls|
|:--:|:--:|:--:|
**CustomerId**|**int**|**false**|
**CustomerName**|**nvarchar(50)**|**true**|
**CustomerSurname**|**nvarchar(50)**|**true**|    

*(Primary Key and auto increment)    

|Tablo adı|
|:--:|
Guide

|Column Name|Data Type|Allow Nulls|
|:--:|:--:|:--:|
**GuideId**|**int**|**false**|
**GuideName**|**nvarchar(50)**|**true**|
**GuideSurname**|**nvarchar(50)**|**true**|    

*(Primary Key and auto increment)    

|Tablo adı|
|:--:|
Location

|Column Name|Data Type|Allow Nulls|
|:--:|:--:|:--:|
**LocationId**|**int**|**false**|
**City**|**nvarchar(50)**|**true**|
**Country**|**nvarchar(50)**|**true**|
**Capacity**|**tinyint**|**true**|
**Price**|**decimal(18, 2)**|**true**|
**DayNight**|**nvarchar(50)**|**true**|
**GuideId**|**int**|**true**|    

*(Primary Key and auto increment)
	
	
3-) Tablolar tamamlandıktan sonra veritabanı üzerindeki Database Diagrams'a sağ tuş tıklayıp New Database Diagram seçeneği seçilir. Program veritabanının değişebileceğine dair bir uyarı gösteriyor. Birkaç uyarı gelebilir. Onayladıktan sonra Add Table isimli bir pencere üzerinden Guide ve Location'ı Add(Tablo adına çift tıklanarak aynı işlem yapılabilir) ile ekliyoruz. Ve close ile pencereyi kapatıyoruz.        
4-) Diagram ekranında beliren tablolardan sonra Guide tablosu içindeki GuideId'i tutup Location içerisindeki GuideId üzerine götürüp bağlıyoruz. Bu sırada iki pencere açılıyor. Önde duran pencere adı Tables and Columns. Bu pencerede Relationship Name: FK_Location_Guide, Primary Key Table: Guide, Foreign Key Table: Location -- Alt kısımlarında birbirine bağlanan sutün adları(column name): GuideId olarak yer alıyor. Gelen iki pencerede onaylandıktan sonra diagram'ı kaydediyoruz. İsmi olduğu gibi bıraktık.             
5-) Diagram üzerinden ilişki tanımlaması yapıldı ve ilişki hazır oldu. Visual Studio'a dönmeden veritabanı sunucusu bağlantı ismi kopyalanır. (Benim için Server name --> DESKTOP-HQRJD4Q\MSSQLSERVER01)      
6-) Visual Studio'da .EFProject projemize sağ tuş tıklayarak Add >> New Item... 'ı seçiyoruz. Burada ufak bir pencere gelirse sol altta Show All Templates 'e tıklıyoruz.    
7-) Gelen pencereden sol tarafta Data >> ADO.NET Entity Data Model'i seçiyoruz. (Herhangi bir isimlendirme yapmadık.) Daha sonra açılan adı Entity Data Model Wizard olan pencerede bize dört seçenek sunuluyor.     
8-) EF Designer from database - Empty EF Designer model - Empty Code First model - Code First from database
9-) EF Designer from database adlı şemayı seçerek devam ediyoruz. Bu arkadaş var olan bir veritabanından EntityFramework Design bazlı modeli bizim için oluşturacak. Seçim sonrası veritabanı bağlantısı ekranı geliyor. New Connection'a tıklayarak gelen Connection Properties ekranından Data Source: Microsoft SQL Server(SqlClient) olacak şekilde seçiyoruz, Server Name: DESKTOP-HQRJD4Q\MSSQLSERVER01, bunlardan sonra Connect to a database bölmesinde veritabanı ismimizi(EgitimKampiEfTravelDb) oradan bulup giriyoruz. Trust Server Certificate'ı işaretliyoruz. Test Connection ile test edebiliriz. Modelin içine hangi objeleri eklemek istediğimizi sorduğu ekranda Tables'ı işaretliyoruz.(Tables >> dbo >> Customer,Guide,Location,sysdiagrams'ın hepsinin mavi tik olduğuna dikkat ediyoruz.)  Devam edip oluşturulduğunda Model1.edmx'in projeye eklendiğini görüyoruz.    
```xml
 <connectionStrings>
    <add name="EgitimKampiEfTravelDbEntities" connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-HQRJD4Q\MSSQLSERVER01;initial catalog=EgitimKampiEfTravelDb;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
```
10-) App.config içerisinde bağlantı adımız yukarıda görüldüğü üzere EgitimKampiEfTravelDbEntities olarak eklenmiş. 
11-) SQL Server Management Studio'a geri dönerek Customer tablomuza CustomerBalance adında yeni bir sütun ekliyoruz.Bunun için Customer Tablosu sağ tuş tık >> Design

|Tablo adı|
|:--:|
Customer

|Column Name|Data Type|Allow Nulls|
|:--:|:--:|:--:|
**CustomerId**|**int**|**false**|
**CustomerName**|**nvarchar(50)**|**true**|
**CustomerSurname**|**nvarchar(50)**|**true**|
**CustomerBalance**|**decimal(18, 2)**|**true**|    

Son hali şu şekilde olacak.

12-) Eklenen sütunun modele yansıtılması için bir güncelleme yapmak gerekiyor. ModelADI.edmx'i kapalı ise açıyoruz.Örneğimiz için Model1.edmx. Açılan ekranda sütun diagramlarımızı gördüğümüz boş bir alana sağ tuş tıklıyoruz. Update Model from Database... Bu seçeneği seçiyoruz. Karşımıza ilk eklemedeki gibi eklemek istediğimizi seçtiğimiz bir pencere geliyor. Eğer yeni bir tablo eklenmemişse bir şey seçmeden gelen pencere ayarları ile finish diyerek işlemi tamamlıyoruz ve Model1.edmx üzerinde Customer tablomuzda artık CustomerBalance ifadesinin yer aldığını görüyoruz. Kaydediyoruz. Bu aşamada bilgisayarınıza güvenli bir kaynak değilse zarar verebileceğine dair bir uyarı görüyoruz. Kabul ediyoruz. Kendi veritabanımız. :)         
13-) SQL Server Management Studio'a geri dönerek tablo ekliyoruz. Tables sağ tuş New >> Table...

|Tablo adı|
|:--:|
Admin

|Column Name|Data Type|Allow Nulls|
|:--:|:--:|:--:|
**AdminId**|**int**|**false**|
**Username**|**nvarchar(50)**|**true**|
**Password**|**nvarchar(50)**|**true**|    

14-) Eklenen tablonun tekrar visual studio tarafında yansıması için Model1.edmx'i güncelliyoruz. Update Model from Database seçeneği ile. Bu sefer tablomuzda değişiklik olduğu için tablomuzu tik kısmını dolduruyoruz. Mavi işaretli olarak devam ediyoruz ve kaydediyoruz.     
15-) Veritabanında yapılan her değişiklik oluşturulan model'e yansıtılmalı(güncellenmeli)
16-) Örnek rehber girişi için Guide Tablomuza gelerek Edit Top 200 Rows seçeneğini seçiyoruz. Ali Yıldız, Ayşegül Çınar, Hakan Kayalı, Neriman Öztürk olarak sahte(uydurma) dört adet rehberlerimizi ekliyoruz.    
17-) Form1.cs kapalı ise açıyoruz ve form alanı içerisine sağ tuş tıklayarak properties kısmına geliyoruz. Gelen properties ayarlarından Appearance kısmından Text karşısında olan yere Rehber İşlemleri olarak giriyoruz.
View >> ToolBox (Ctrl + Alt + X) kapalı ise açıyoruz. Label ekliyoruz.
Yanına TextBox ekliyoruz. Alt kısımına Buton ekliyoruz. DataGridView ekliyoruz.
Label için Appearance text kısmına Rehber Id: veriyoruz. Design Name kısmına lbl_RehberId.
TextBox için Design kısmına txtbox_RehberId veriyoruz. İkisini kopyalayarak alta 2 sefer yapıştırıyoruz.
Toplamda 3 label ve 3 text box olmuş oluyor. Yapıştırdığımız label Rehber Adı: ve Rehber Soyadı: olarak değiştiriyoruz. Design kısmını unutmuyoruz.
Var olan butonun adını Listele yapıyoruz ve toplamda 5 buton olacak şekilde alt alta kopyalıyoruz.
Buton adları: Listele, Ekle, Sil, Güncelle, ID'e göre getir. Design kısımlarına ona uygun isimler veriyoruz. btn_List, btn_Add, btn_Delete, btn_Update, btn_GetById şeklinde...
Butonları seçip bir arka plan rengi verilebilir.     
18-) Listele butonuna çift tıklama sonrasında Form1.cs içerisinde ismini btn_List yaptığımız için metot adı btn_List_Click() olarak geçiyor._
```csharp
 private void btn_List_Click(object sender, EventArgs e)
        {
            //App.config içerisinde connectionString'in Add tagında name property'si üzerinden yeni bir obje oluşturuyoruz
            EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

            // Oluşturduğumuz veritabanı objesi ile ilgili tabloya(Guide) ulaşıyoruz 
            //ve ToList() metotu ile tüm tablo verilerini List<Guide> türünde daha önce oluşturduğumu allGuideTable içerisine alıyoruz.
            var allGuideTable = db.Guide.ToList();

            // Form içerinde oluştrudğumuz DataGridView'in DataSource property'sine allGuideTable'ı atayarak listelemeyi gerçekleştirmiş oluyoruz.
            dataGridView1.DataSource = allGuideTable;
        }
```
19-) Form1.cs[Design] üzerine gelip Ekle butonuna çift tıklıyoruz bu sefer.

```csharp
 private void btn_Add_Click(object sender, EventArgs e)
 {
     // Burada txtbox_RehberAdi verdiğimiz kısımdan kullanıcıdan rehber adını alıyoruz.
     var rehberAdi = txtbox_RehberAdi.Text;
     // Burada txtbox_RehberSoyadi verdiğimiz kısımdan kullanıcıdan rehber soyadını alıyoruz.
     var rehberSoyadi = txtbox_RehberSoyadi.Text;  
     
     //Entity Framework ekleme işlemlerinde o sınıfa ait bir obje bekliyor. O sebeple o nesneyi türetiyoruz.
     Guide guide = new Guide();
     // Türettiğimiz nesnenin ismine rehberAdi değişkenine gelen değeri atıyoruz.
     guide.GuideName = rehberAdi;
     // Türettiğimiz nesnenin soyisim kısmına rehberSoyadi değişkenine gelen değeri atıyoruz.
     guide.GuideSurname = rehberSoyadi;
     //Artık nesnemizin property kısmı hazır olduğuna göre işi entityframework'e devrediyoruz.
      db.Guide.Add(guide);
     //Kalıcı olması için  db.SaveChanges(); metodunu çağırmayı unutmuyoruz.

     //Ben burada biraz değişikliğe gittim ve sınıfım alttaki gibi görünür oldu. Kursiyer denemeleri Vol 2 :)
               
 }

```     

20-) Sıradaki işlem silme. Benzer adımları uyguladıktan sonra

```csharp
 private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtbox_RehberId.Text, out id)) {
                // id ile guide entity elde ediyoruz.
                var guide = db.Guide.Find(id);

                // Bu arkadaş silmek için bir entity istiyor.
                db.Guide.Remove(guide);
                db.SaveChanges();
                List();
            }
        }
```     

21-) Sıradaki işlem güncelleme

```csharp
 private void btn_Update_Click(object sender, EventArgs e)
{
int id = int.Parse(txtbox_RehberId.Text);
var guide = db.Guide.Find(id);
guide.GuideName = txtbox_RehberAdi.Text;
guide.GuideSurname = txtbox_RehberSoyadi.Text;           
db.SaveChanges();
List();
}
```    

22-) Sıradaki işlem id'e göre getir

```csharp
  private void btn_GetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtbox_RehberId.Text);
            var values = db.Guide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
```


```csharp
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void List()
        {
            var allGuideTable = db.Guide.ToList();
            dataGridView1.DataSource = allGuideTable;
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            //EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

            //var allGuideTable = db.Guide.ToList();
            //dataGridView1.DataSource = allGuideTable;

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
                    int rowindex = dataGridView1.CurrentCell.RowIndex;
                    var id = dataGridView1.Rows[rowindex].Cells["GuideId"].Value;
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
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                var id = dataGridView1.Rows[rowindex].Cells["GuideId"].Value;
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
            dataGridView1.DataSource = values;
        }
    }
}


```

