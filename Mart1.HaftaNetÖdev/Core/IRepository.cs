using System.Collections.Generic;

namespace Mart1.HaftaNetOdev.Core
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);  
        List<T> GetAll();
        T GetById(int id);
    }
}