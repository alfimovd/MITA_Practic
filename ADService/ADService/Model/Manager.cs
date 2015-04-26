using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;
using Mita.DataAccess;

namespace ADService.DataAccess.Model
{
    public class Manager : FullNamedDomainObject
    {
        [Required]
        public int BranchId { get; set; }

        [Required]
        public Branch Branch { get; set; }
        public User User { get; set; }

    }
}
