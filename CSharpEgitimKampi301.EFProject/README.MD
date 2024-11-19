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