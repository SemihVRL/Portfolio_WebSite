using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Insert(T t)
        {
            using var context = new Context();
            context.Add(t);
            context.SaveChanges();
        }

       
        public void Delete(T t)
        {
            using var context = new Context();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            using var context = new Context();
            return context.Set<T>().Find(id);
        }
        public void Update(T t)
        {
            using var context = new Context();
            context.Update(t);
            context.SaveChanges();
        }
        public List<T> GetList()
        {
            using var context = new Context();
            return context.Set<T>().ToList();
        }

       
    }
}
 