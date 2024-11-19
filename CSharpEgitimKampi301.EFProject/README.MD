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
**CustomerId**|[**int**]|[**false**]|
**CustomerName**|**nvarchar(50)**|**true**|
**CustomerSurname**|**nvarchar(50)**|**true**|    


	
	
