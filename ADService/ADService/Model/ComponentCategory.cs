
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;

namespace ADService.DataAccess.Model
{
    public class ComponentCategory : TitledDomainObject
    {
        public string Description { get; set; }
        public virtual ICollection<Component> Components { get; set; }
    }
}
