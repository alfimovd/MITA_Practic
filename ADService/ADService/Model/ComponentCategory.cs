
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;

namespace ADService.Model
{
    public class ComponentCategory : NamedDomainObject
    {
        public string Description { get; set; }
        public virtual ICollection<Component> Components { get; set; }
    }
}
