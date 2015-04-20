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

        public int CategoryId { get; set; }
        public ComponentCategory Category { get; set; }
        public virtual ICollection<SupplierComponent> SupplierComponents { get; set; }
        //многие ко многим
        public virtual ICollection<Transport> Transports { get; set; }

        public Component()
        {
            Transports = new List<Transport>();
        }
    }
}
