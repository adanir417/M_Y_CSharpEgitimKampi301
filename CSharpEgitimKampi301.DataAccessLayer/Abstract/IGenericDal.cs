using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        // Bu arkadaş veri tabanı işlemlerinin şablonunu tutacak
        // CRUD - Create - Read - Update - Delete
        // <T> T tipinde bir şey ile çalışacaksın ve
        // bu şey bir sınıf olmalı --> where T : class
        //                             T gördüğün yerde : sınıf ara

        /*
        <T> where T : class Kısıtlaması
        Bu kısıtlama, şablona verilecek T parametresinin mutlaka bir sınıf (class) olması gerektiğini belirtir. 
        Yani, T yerine sadece int, double gibi temel veri tipleri değil, kullanıcı tarafından tanımlanmış sınıflar veya struct'lar gelebilir.
         */


        // Create
        // Parametre olarak T türünce yani miras alan sınıfta tanımlandığı sınıf tipinde bir obje bekliyor olacak.
        // Customer türünde bir obje gibi veya Product türünce bir obje gibi. 
        void Insert(T entity);

        // Read - V1 - Id ile oku
        T GetById(int id);

        // Read - V2 - Tüm değerleri oku
        List<T> GetAll();

        // Update
        void Update(T entity);

        // Delete
        void Delete(int id);


        // Generic oluşturulduktan sonra her bir entitiy sınıfımız içinde interface oluşturup bu arkadaşı miras alıyoruz.
        // Admin için miras aldığımızda sınıfı <> içerisine belirtiyoruz ve access modifier'ı public olarak ayarlıyoruz. 
        /*
          public interface IAdminDal:IGenericDal<Admin>
          {
          }
         */
    }
}
