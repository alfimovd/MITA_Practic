﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.DataAccess.Model;
using Mita.DataAccess;

namespace ADService.Model
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
