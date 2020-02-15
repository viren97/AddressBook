using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook.DataProvider
{
    public class AddressBookRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context = null;
        public AddressBookRepository(AddressBookContext context)
        {
            _context = context;   
        }
        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
          
        }
        public IList<T> GetAll()
        {
            return _context.Set<T>().ToList();
           
        }
        public void Delete(object id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }
    }
}
