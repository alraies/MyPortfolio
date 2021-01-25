using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IGenericRepository<T>  where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(Object Id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(Object Id);


    }
}
