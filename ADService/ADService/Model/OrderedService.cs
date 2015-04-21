using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;

namespace ADService.DataAccess.DataAccess.Model
{
    public class OrderedService : DomainObject
    {

        public int OrderId { get; set; }

        public int ServiceId { get; set; }

        public double Price { get; set; }


        public Order Order { get; set; }

        public Service Service { get; set; }
    }
}
