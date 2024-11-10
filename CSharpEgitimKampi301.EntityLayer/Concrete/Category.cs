using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }


        //field - Variable - Property

        // Bir değişken sınıfın içine tanımlanırsa field
        // Eğer değişken yapısı get ve set olarak değer alırsa property
        // Eğer method içerisinde tanımlanırsa değişken.

        //Otomatik artan bir id olduğunu tanımlamak için SınıfAdı + Id eki ile tanımlama yapmalı
        // Category sınıfı için public int CategoryId { get; set; }

        //Tüm bu sınıf ile ilgili olan property'ler tablolarda sütunlara(Column) karşılık gelecek.


        /*
         Code First - Bire çok ilişki - one to many

        Her bir ürünün bir tane kategorisi olacağı için önce
        ürün sınıfında(Product.cs) 

        public int CategoryId { get; set; }

        tanımlandı ve sonrasında 

        public virtual Category Category { get; set; }

        Kategori objesi de tanımlanarak ilişki Product sınıfı için tamamlandı.
        
        Kategori sınıfı(Category.cs) içerisinde ise

        public List<Product> Products { get; set; }

        bir kategorinin birden fazla ürün barındırabileceği için List<Product> tipinde bir ürünler tanımlandı.

        Böylelikle bire çok ilişki Category(one) Product(many) olarak tanımlandı.

         */
    }
}
