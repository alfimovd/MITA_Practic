using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TenantsManager.Model1
{
    public class TenantRepository : MemoryRepository<Tenant>
    {
        public TenantRepository()
        {
            Add(new Tenant
            {
                Name = "1",
                Birthday = new DateTime(),
                Debt = 352.5,
                IsDeleted = false
            });
            Add(new Tenant
            {
                Name = "2",
                Birthday = new DateTime(),
                Debt = 352.5,
                IsDeleted = false
            });
            Add(new Tenant
            {
                Name = "3",
                Birthday = new DateTime(),
                Debt = 352.5,
                IsDeleted = false
            });
            Add(new Tenant
            {
                Name = "4",
                Birthday = new DateTime(),
                Debt = 352.5,
                IsDeleted = true
            });
            Add(new Tenant
            {
                Name = "5",
                Birthday = new DateTime(),
                Debt = 352.5,
                IsDeleted = false
            });
            Add(new Tenant
            {
                Name = "6",
                Birthday = new DateTime(),
                Debt = 352.5,
                IsDeleted = false
            });
        }
    }
}
