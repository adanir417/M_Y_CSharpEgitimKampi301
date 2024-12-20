# CSharpEgitimKampi301

---

Murat YÜCEDAĞ [C# Eğitim Kampı](https://www.youtube.com/playlist?list=PLKnjBHu2xXNPmFMvGKVHA_ijjrgUyNIXr)     
Check original repository => [C# Eğitim Kampı Original Repository](https://github.com/MuratYucedag/CSharpEgitimKampi)    
Check original repository => [C# Eğitim Kampı Original Repository - Part 2](https://github.com/MuratYucedag/CSharpEgitimKampi301)    
Check original repository => [C# Eğitim Kampı Original Repository - Part 3](https://github.com/MuratYucedag/CSharpEgitimKampi501)    

---



## Dersler
### Module 301 - Completed    
---    
### :green_circle: Ders 11 - OOP Modülü: C# ile N Katmanlı Mimari Entity Layer    
Boş bir solution içinde katmanlar nasıl eklenir?, Entity içinde tablolara karşılık gelecek sınıflar nasıl oluşturulur?,    
Oluşturulan sınıflar içindeki Property yapıları tablolarda hangi konuma işaret eder? Ve Erişim belirleyiciler nasıl işler?    
Bu ders içerisinde bunları anladım.     

---    
### :green_circle: Ders 12 - OOP Modülü: Data Access Katmanı ve Context Sınıfı    
Sınıflar arası ilişkilendirmelerin gerçek hayata benzer şekilde yazılımını anladım. Katmanlar arası haberleşmenin referanslar aracılığı 
ile olduğunu anladım. Veritabanına bağlantı kuracak Context sınıfının tanımlanması ve bu sınıf içerisinde tablo adlarının çoğul, sınıf adlarının
tekil şekilde kullanıldığını öğredim.     

Örnek:    
```csharp
 public DbSet<Category> Categories { get; set; }
 public DbSet<Product> Products { get; set; }
 public DbSet<Order> Orders { get; set; }
 public DbSet<Customer> Customers { get; set; }
 public DbSet<Admin> Admins { get; set; }
```    

ConnectionString'in App.Config içine yazıldığını öğrendim. Burada dikkat edilecek iki nokta:    
1-) Programın çalıştığı App.config içerisine yazmamız(CSharpEgitimKampi301.PresentationLayer)    
2-) App.config içerisinde yerleştiriği alana dikkat edelim. 
```xml </configuration>``` tag'ı öncesine yerleştirildi ve Add tag'a name, connectionString ve providerName property(özellik)leri eklenerek tamamlandı.
Add tag'ının "/>" ile kapandığına dikkat edelim. 

```xml
  </entityFramework>
	<connectionStrings>
		<add name="KampContext" connectionString="Data Source=DESKTOP-HQRJD4Q\MSSQLSERVER01;initial Catalog=EgitimKampi301Db;integrated security=true" providerName="System.Data.SqlClient" />
	</connectionStrings>
</configuration>
```     

Proje üzerine paket yöneticisi ile paket eklemeyi öğrendim. Gerekli paketlerin eklendikten sonra referansları üzerinden yüklenip yüklenmediğini 
kontrol edebildiğimizi öğrendim. Virtual keyword'unu ilişkilendirmede kullandık. Bu anahtar kelime property, method, indexer ve etkinlik tanımının 
üzerinde overridden kullanımına izin veren yapıyı oluşturur. Yani onu miras alan sınıfta değişikliği sağlanabilir. Daha fazla bilgi için linkler 
ziyaret edilebilir.


[virtual (C# Reference)](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual)
[Entity Framework Code-First ilişkili tablolarda neden ‘Virtual’ kullanırız? - Serhat AYATA](https://medium.com/@srhtayata/entity-framework-code-first-ili%C5%9Fkili-tablolarda-neden-virtual-kullan%C4%B1r%C4%B1z-2513de036592)
[Knowing When to Use Override and New Keywords (C# Programming Guide)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords)

---    
### :green_circle: Ders 13 - OOP Modülü: Migration İşlemleri ve Abstract Interfaceler    
How to open Package Manager Console --> View >> Other Windows >> Package Manager Console     
Migration işlemleri yapılacağı zaman katman doğru seçilmeli. Package Manager Console açıldıktan sonra Default project kısmında yer alan projenin     
DataAccessLayer seçilmesi gerekiyor. Çünkü DbContext sınıfımız orada yer alıyor.    
Package Manager Console Commands      
Clear, clear --> Konsolu temizler.       
enable-migrations --> Migration'ı aktif hala getirir.Komut sonrası ilgili projede herhangi bir sorun olmazsa    
                      Migrations adında bir klasör oluşturuluyor ve içerisine Configuration.cs sınıfı oluşturuluyor.     
					  Default: AutomaticMigrationsEnabled = false;     
					  Eğitim kampı için bu ifade AutomaticMigrationsEnabled = true; şeklinde değiştirildi.     
update-database --> Kurulan şemaları veri tabanı üzerinde hazır hale getirir.     
update-database -verbose --> Kurulan şemaları veri tabanı üzerinde hazır hale getirir.(Detayları görünür kılar)     
add-migration MigrationADI --> Verilen isimde bir migration oluşturur.          
                               Burada tarih-saat-verilenMigrationADI ile bir sınıf oluşturuluyor      
							   Bu sınıf içerisinde iki method öne çıkıyor Up() ve Down() 
							   Up() --> Update halinde uygulanacak komutları içeriyor.
							   Down() --> Geri alınma halinde uygulanacak komutları içeriyor.      


Repository Pattern uygulanışı gösterildi. DataAccessLayer içerisindeki Abstract klasörüne önce     
IGenericDal isimli bir interface oluşturduk ve access modifier'ı public şekilde değiştirdik. IGenericDal için Beş(5) adet metot yazdık.    
Daha sonra aynı klasöre EntityLayer içindeki Concrete klasöründeki entity sınıfları için sırası ile     
I + SINIFADI + Dal şeklinde interfaceler oluşturduk. Örnek IAdminDal, ICustomerDal, IProductDal...    
Erişim belirleyicileri public'e alındı ve IGenericDal< EntityADI > miras alındı.    

Örnek     
```csharp
public interface IAdminDal:IGenericDal<Admin>
    {
    }

	VEYA

 public interface ICustomerDal:IGenericDal<Customer>
    {
    }
```

IGenericDal(Yazılan metotlar) -->
```csharp
Create(1) --> void Insert(T entity);
Read(2) --> T GetById(int id) , List<T> GetAll();
Update(1) --> void Update(T entity);
Delete(1) --> void Delete(int id);
```   

IGenericDal (Sınıf gösterimi) -->     
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {    
        void Insert(T entity);
        
        T GetById(int id);
        
        List<T> GetAll();
     
        void Update(T entity);
        
        void Delete(int id);     
    }
}
```    

[Migrations Overview - TR](https://learn.microsoft.com/tr-tr/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)     
[Migrations Overview - EN](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)      
[Design-Patterns - Tasarım Desenleri](https://refactoring.guru/design-patterns/structural-patterns)    

					  
---    
### :green_circle: Ders 14 - Orm Yapısı: Entity Framework DbFirst ve Model Oluşturma    
### :green_circle: Ders 15 - Entity Framework Metotları ile Proje Uygulaması    
### :green_circle: Ders 16 - Entity Framework: Tur Projesi Location İşlemleri    
### :green_circle: Ders 17 - Entity Framework Metotları ve Linq Sorgular   
Eğitim kampı içerisinde DBFirst yaklaşımı ile veritabanını projeye dahil etmeyi ve kullanmayı, basitçe form arayüzü oluşturmayı öğrendim.    
Linq kullanarak basit sorgular yazmayı öğrendim. Anonim sınıf oluşturmayı gözlemledim, benim için hala biraz karışık :monocle_face:.     
[İzlenen yollar ve çeşitli açıklamalar içeride](https://github.com/adanir417/M_Y_CSharpEgitimKampi301/tree/master/CSharpEgitimKampi301.EFProject)     
### - Main Menu    
![Main Menu](https://github.com/adanir417/M_Y_CSharpEgitimKampi301/blob/master/CSharpEgitimKampi301.EFProject/pics/MainMenuForm.png)     
### - Guide Form    
![Guide Form](https://github.com/adanir417/M_Y_CSharpEgitimKampi301/blob/master/CSharpEgitimKampi301.EFProject/pics/GuideForm.png)      
### - Location Form  
![Location Form](https://github.com/adanir417/M_Y_CSharpEgitimKampi301/blob/master/CSharpEgitimKampi301.EFProject/pics/LocationForm.png)      
### - Statistic Form    
![Statistic Form](https://github.com/adanir417/M_Y_CSharpEgitimKampi301/blob/master/CSharpEgitimKampi301.EFProject/pics/StatisticForm.png)     
    
### :green_circle: Ders 18 - EntityState Komutları, Generic Repository Sınıfı ve Ef Sınıfları
Bu ders sonunda DataAccessLayer içerisinde Entity'leri veritabanına kaydedecek yapı oluşumunu öğredim. 
5 Adet entity hazırlamıştık. Bu hazırladıklarımız içinde 1 adet IGenericDal isminde genel bir şablon ve o entity'e ait olabilecek
özel methodların imzalarını tutacak şablonlar hazırladık. Abstract(6 Interface(1 IGenericDal + 5 IEntityNameDal)). 
Bu imzaların kullanımının gerçekleşmesi adına sınıfları hazırladık. Repository(1 GenericRepository) + EntityFramework(5 EfEntityNameDal)
Kuş bakışı baktığımızda ne kadar imza method varsa o kadar gerçek sınıf karşılığı var diyebilirim.     
Abstract(6 Interface(1 IGenericDal + 5 IEntityNameDal)) = Repository(1 GenericRepository) + EntityFramework(5 EfEntityNameDal)     
     
Önemli noktalar     
IGenericDal `public interface IGenericDal<T> where T : class` T tipinin sınıf kısıtlaması olduğunu belirtiyor.     
IEntityNameDal `public interface IAdminDal:IGenericDal<Admin>` Miras alırken T yerine Entity Tipi belirtiliyor.    
GenericRepository `public class GenericRepository<T> : IGenericDal<T> where T : class` T tipinin sınıf kısıtlaması olduğunu belirtiyor.    
EfEntityNameDal `public class EfAdminDal:GenericRepository<Admin>, IAdminDal` Miras alırken T yerine Entity Tipi belirtiliyor.    
     
Miras alanlar entity belirtiyor. Miras bırakanlar gönderilen tipe göre işlem yapıyor.      


### :green_circle: Ders 19 - Business Katmanı ve Logic Kurallar     
BusinessLayer içerisine Abstract ve Concrete olmak üzere iki klasör tanımladık. Bunlardan Abstract içerisine gelen IGenericService, 
IGenericDal'ın içerdiği metodları içerecek ve DataAccessLayer için bir köprü olacak.Daha sonra IGenericService'i miras alacak entity(IEntityADIService) interfacelerini yazdık.
Concrete içerisine ise bu imza metodların işlevsel hale geleceği ve Business Logic ile 
birlikte yer alacağı EntityADIManager.cs isim şablonu ile business logic'e ihtiyaç duyan her bir entity için bir manager sınıfı oluşturduk.
Bu Manager sınıfları kendi adlarını içeren servisleri miras aldı ve miras aldığı metodları implemente etti. Manager sınıfları içerisinde oluşturulan
IProductDal, IOrderDal Objesi oluşturduk ve bir yapılandırıcı method ile atamasını yaptık. Burada DependencyInjection konusu gelecek...       
Oluşturduğumuz obje ile methodları logic(mantık) sorgularını geçerse işleyecek yapıyı kurduk.    


### :green_circle: Ders 20 - Dependency Injection        
Dependency injection kısmını sunum katmanımızda yapılandırıcı methoda istenen objeyi vererek gerçekleştirdik. Taklit kategorilerimizi ekledik.

```csharp

ICategoryDal categoryDal = new EfCategoryDal();
_categoryService = new CategoryManager(categoryDal);

 VEYA

 _categoryService = new CategoryManager(new EfCategoryDal());

```
 
|Tablo adı|
|:--:|
Category

|CategoryId|CategoryName|CategoryStatus|
|:--:|:--:|:--:|
**1**|**Yiyecek**|**true**|
**2**|**İçecek**|**true**|
**3**|**Kırtasiye**|**true**|
**4**|**Beyaz Eşya**|**false**|
**5**|**Bitkiler**|**true**|
**6**|**Kıyafetler**|**true**|
**7**|**Oyuncak**|**false**|     


FrmCategory isimli formumuzun butonlarını yazdık ve işlevsel hale getirdik.      
Category tablosuna ekleme işlemine üşenenler için toplum hizmeti.     
     
VeritabanıAdı.dbo.TabloAdı      
EgitimKampi301Db.dbo.Categories          
     
Tabloya erişilen yol kısmını kendinize göre düzenleyip query'i çalıştırırsanız kategorileriniz eklenecektir.     

```sql
INSERT INTO EgitimKampi301Db.dbo.Categories (CategoryName,CategoryStatus) 
VALUES
('Yiyecek','1'),
('İçecek','1'),
('Kırtasiye','1'),
('Beyaz Eşya','0'),
('Bitkiler','1'),
('Kıyafetler','1'),
('Oyuncak','0');
```     

### :green_circle: Ders 21 - Entitye Özgü Metot Yazmak      

FrmProduct formumuzu oluşturarak Programs.cs içindeki başlatma bölümünü ayarladık. Taklit ürünlerimizi ekledik.

|Tablo adı|
|:--:|
Product

|ProductId|ProductName|ProductStock|ProductPrice|ProductDescription|CategoryId|
|:--:|:--:|:--:|:--:|:--:|:--:|
**1**|**Makarna**|**50**|**10**|**test**|**1**|
**2**|**Pasta**|**20**|**25**|**test**|**1**|
**3**|**Portakal**|**100**|**5**|**test**|**1**|
**4**|**Su**|**250**|**1**|**test**|**2**|
**5**|**Çam Ağacı**|**60**|**10**|**test**|**5**|
**6**|**Kazak**|**50**|**12**|**test**|**6**|
**7**|**Çorap**|**300**|**2**|**deneme**|**6**|
**8**|**Top Seti**|**20**|**10**|**test**|**7**|
**9**|**Limonata**|**25**|**30**|**test**|**2**|
**10**|**Etek**|**10**|**15**|**test**|**6**|
       
Kategorileri el ile girmek istemeyenler için toplum hizmeti :)    

```sql
INSERT INTO EgitimKampi301Db.dbo.Products 
(ProductName,ProductStock,ProductPrice,ProductDescription,CategoryId) 
VALUES 
('Makarna','50','10','test','1'),
('Pasta','20','25','test','1'),
('Portakal','100','5','test','1'),
('Su','250','1','test','2'),
('Çam Ağacı','60','10','test','5'),
('Kazak','50','12','test','6'),
('Çorap','300','2','deneme','6'),
('Top Seti','20','10','test','7'),
('Limonata','25','30','test','2'),
('Etek','10','15','test','6');
```   

DataAccessLayer.Abstract.IProductDal içerisine yeni bir imza method tanımlıyoruz ve DataAccessLayer.EntityFramework.EfProductDal içerisine bu metodu dolduruyoruz.    

DataAccessLayer.Abstract.IProductDal
```csharp
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        List<Object> GetProductsWithCategory();
    }
}
```     

DataAccessLayer.EntityFramework.EfProductDal    
```csharp
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new KampContext();
            var values = context.Products.Select(x => new { 
            ProductId = x.ProductId,
            ProductName = x.ProductName,
            ProductStock = x.ProductStock,
            ProductPrice = x.ProductPrice,
            ProductDescription = x.ProductDescription,
            CategoryName = x.Category.CategoryName
            }).ToList();

            return values.Cast<object>().ToList();
        }
    }
}

```    

DataAccessLayer işlemleri bittikten sonra Business katmanına işliyoruz.   

BusinessLayer.Abstract.IProductService     
```csharp
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<object> TGetProductsWithCategory();
    }
}

```    

BusinessLayer.Abstract.ProductManager
```csharp
  public List<object> TGetProductsWithCategory()
        {
            return _productDal.GetProductsWithCategory();
        }
```    


Geri kalan buton metotlarımızı tamamladık ve çalıştığına emin olarak projemizi bitirdik ve Dapper isimli ORM aracına geçiş yapıyoruz...    

### :green_circle: Ders 22 - C# ile Dapper Kullanımı    
[Ders 22 ve sonrası için link üzerinden devam - https://github.com/adanir417/CSharpEgitimKampi501 ](https://github.com/adanir417/CSharpEgitimKampi501)




