﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mita.DataAccess;

namespace ADService.Model
{
    public class Service : TitledDomainObject
    {
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public ServiceCategory Category { get; set; }
    }
}