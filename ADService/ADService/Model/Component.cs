﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;

namespace ADService.Model
{
    public class Component : TitledDomainObject
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }

        public int CategoryId { get; set; }
        public ComponentCategory Category { get; set; }
    }
}
