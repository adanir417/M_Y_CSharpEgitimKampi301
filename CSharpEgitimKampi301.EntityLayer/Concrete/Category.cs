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



        //field - Variable - Property

        // Bir değişken sınıfın içine tanımlanırsa field
        // Eğer değişken yapısı get ve set olarak değer alırsa property
        // Eğer method içerisinde tanımlanırsa değişken.

        //Otomatik artan bir id olduğunu tanımlamak için SınıfAdı + Id eki ile tanımlama yapmalı
        // Category sınıfı için public int CategoryId { get; set; }

        //Tüm bu sınıf ile ilgili olan property'ler tablolarda sütunlara(Column) karşılık gelecek.
    }
}
