using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantsManager.Model
{
    public class TenantsContext : DbContext
    {
        public TenantsContext() : base("TenantsConnection") { }
        public IDbSet<Tenant> Tenants { get; set; }
 
    }
}
