using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; }

        //Eklemeyi unuttuğumuz tablo sütunu örneği
        //Ekleme yapmadan önce uygulanan komutlar
        // enable-migrations
        // Configuration.cs içerisindeki AutomaticMigrationsEnabled = true; ifade şu şekle çevirildi.
        // update-database

        public bool CustomerStatus { get; set; }

        // add-migration customerstatusaddedtoCustomer ile migration oluşturuldu.
        // update-database ile değişiklik veri tabanına yansıtıldı.



    }
}
