using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        KampContext kampContext = new KampContext();

        private readonly DbSet<T> _object;

        public GenericRepository()
        {
            _object = kampContext.Set<T>();
        }

        public void Delete(T entity)
        {
            // Bu arkadaş veritabanı üzerindeki tablo ile iletişimi sağlamak adına
            // verilen tipe karşılık gelen entity objesini 
            var deletedEntity = kampContext.Entry(entity);
            // Bu arkadaş veritabanı üzerindeki kısımda yapılacak işlemi bu şekilde işaretliyor ve
            // SaveChanges(); Metodu çağrıldığında işaretlendiği gibi hareket ediyor.
            deletedEntity.State = EntityState.Deleted;
            kampContext.SaveChanges();

           
            
        }

        public List<T> GetAll()
        {
           return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var addedEntity = kampContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            kampContext.SaveChanges();
        }

        public void Update(T entity)
        {
           var updatedEntity = kampContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            kampContext.SaveChanges();
        }
    }
}
