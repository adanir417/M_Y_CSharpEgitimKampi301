using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
      
        void TInsert(T entity);
       
        T TGetById(int id);
       
        List<T> TGetAll();

        // Update
        void TUpdate(T entity);

        // Delete
        void TDelete(T entity);

    }
}
