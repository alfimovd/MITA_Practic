using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;

namespace ADService.DataAccess.Model
{
    public class BranchService : DomainObject
    {

        public int BranchId { get; set; }

        public int ServiceId { get; set; }

        public double Price { get; set; }


        public Branch Branch { get; set; }

        public Service Service { get; set; }
    }
}
