using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TenantsManager.Model1
{
    public class Tenant : IDomainObject
    {
        public int id { get; set; }
        
        public string Name { get; set; }

        public double Debt { get; set; }

        public DateTime Birthday { get; set; }

        public bool IsDeleted { get; set; }
    }
}
