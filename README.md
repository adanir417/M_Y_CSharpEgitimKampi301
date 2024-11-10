# CSharpEgitimKampi301

---

Murat YÜCEDAĞ [C# Eğitim Kampı](https://www.youtube.com/playlist?list=PLKnjBHu2xXNPmFMvGKVHA_ijjrgUyNIXr)    
Check original repository => [C# Eğitim Kampı Original Repository](https://github.com/MuratYucedag/CSharpEgitimKampi)
Check original repository => [C# Eğitim Kampı Original Repository - Part 2](https://github.com/MuratYucedag/CSharpEgitimKampi301)

---



## Dersler
### Module 301 - Continue    
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
IGenericDal isimli bir interface oluşturduk ve access modifier'ı public şekilde değiştirdik. Beş(5) adet metod yazdık.    
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

```csharp
Create(1) --> void Insert(T entity);
Read(2) --> T GetById(int id) , List<T> GetAll();
Update(1) --> void Update(T entity);
Delete(1) --> void Delete(int id);
```     

[Migrations Overview - TR](https://learn.microsoft.com/tr-tr/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)
[Migrations Overview - EN](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)
[Design-Patterns - Tasarım Desenleri](https://refactoring.guru/design-patterns/structural-patterns)

					  

