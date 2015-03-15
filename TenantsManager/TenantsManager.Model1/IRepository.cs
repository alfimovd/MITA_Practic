using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TenantsManager.Model1
{
    public interface IRepository<TItem> where TItem : IDomainObject
    {
        void Add(TItem item);
        void Remove(TItem item);
        TItem Find(int id);
        IEnumerable<TItem> GetAll();
    }
}
