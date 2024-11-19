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
	
	
