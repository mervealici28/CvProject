using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
       public void Delete(T t)
        {
            throw new NotImplementedException();
        }

        public T GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetListAll()
        {
            Context c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            Context c = new Context();
            c.Add(t);
            c.SaveChanges();

        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
