using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        DbCvEntities1 db = new DbCvEntities1();

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }

        public int TAdd(T p)
        {
            db.Set<T>().Add(p);
            return db.SaveChanges();
        }
        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();

        }
        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }
        public void Update(T p)
        {
            db.SaveChanges();

        }
        public T Find(Expression<Func<T, bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }
    }
}
