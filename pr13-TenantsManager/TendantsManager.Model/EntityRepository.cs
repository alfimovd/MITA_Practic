using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantsManager.Model
{
    public class EntityRepository<T> : IRepository<T> where T : class, IDomainObject
    {
        private readonly DbContext _dbContext;

        public EntityRepository(DbContext db)
        {
            _dbContext = db;
        } 
        public void Add(T item)
        {
            var dbSet = _dbContext.Set<T>();
            dbSet.Add(item);
        }

        public void Remove(T item)
        {
            var dbSet = _dbContext.Set<T>();
            dbSet.Remove(item);
        }

        public T Find(int id)
        {
            var dbSet = _dbContext.Set<T>();
            var item = dbSet.Find(id);
            return item;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }
    }
}
