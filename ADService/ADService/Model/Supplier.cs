using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;

namespace ADService.Model
{
    public class Supplier : TitledDomainObject
    {
        public string Description { get; set; }
        public virtual ICollection<SupplierComponent> SupplierComponents { get; set; }
    }
}
