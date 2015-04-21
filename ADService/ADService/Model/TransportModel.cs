using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;

namespace ADService.DataAccess.Model
{
    public class TransportModel : TitledDomainObject
    {
        public string Description { get; set; }

        public virtual ICollection<Transport> Transports { get; set; }
        public TransportManufacturer Manufacturer { get; set; }
        public int ManufacturerId { get; set; }
    }
}
