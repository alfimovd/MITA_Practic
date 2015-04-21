using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;

namespace ADService.DataAccess.DataAccess.Model
{
    public class OrderedComponent : DomainObject
    {
        public int OrderId { get; set; }

        public int SupplierId { get; set; }

        public int ComponentId { get; set; }

        public double Price { get; set; }

        public int Amount { get; set; }

        public TimeSpan DeliveryTime { get; set; }

        public Supplier Supplier { get; set; }
        public Order Order { get; set; }

        public Component Component { get; set; }
    }
}
