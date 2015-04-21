using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;

namespace ADService.DataAccess.DataAccess.Model
{
    public class ServiceCategory : TitledDomainObject
    {
        public string Description { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
