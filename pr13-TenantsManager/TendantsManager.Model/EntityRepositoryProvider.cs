using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantsManager.Model
{
    public class EntityRepositoryProvider<TDbContext> : IRepositoryProvider where TDbContext : DbContext, new()
    {
        private readonly TDbContext _dbContext;
        private bool _isDisposed = false;
        public EntityRepositoryProvider()
        {
            _dbContext = new TDbContext();
        } 
        public void Dispose()
        {
            if (!_isDisposed)
            {
                _dbContext.Dispose();
                _isDisposed = true;
            }
        }

        public IRepository<T> GetRepository<T>() where T : class, IDomainObject
        {
            if (!_isDisposed)
            {
                return new EntityRepository<T>(_dbContext);
            }
            
            throw new ObjectDisposedException(GetType().Name);
        }

        public void SaveChanges()
        {
            if (!_isDisposed)
            {
                _dbContext.SaveChanges();
                return;
            }

            throw new ObjectDisposedException(GetType().Name);
        }
    }
}
