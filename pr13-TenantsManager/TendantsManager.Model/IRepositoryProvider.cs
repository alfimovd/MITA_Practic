using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantsManager.Model
{
    public interface IRepositoryProvider : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class, IDomainObject;
        void SaveChanges();
    }
}
