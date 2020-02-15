using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook.DataProvider
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        T GetById(object id);
        IList<T> GetAll();
        void Delete(object id);
    }
}
