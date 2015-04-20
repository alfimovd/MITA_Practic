using System;
using System.Collections.Generic;
using Mita.DataAccess;

namespace ADService.Model
{
    public class Order : DomainObject
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int TransportId { get; set; }
        public Transport Transport { get; set; }

        public int ManagerId { get; set; }
        public Manager Manager { get; set; }

        public DateTime Date { get; set; }
        public ICollection<OrderedComponent> OrderedComponents { get; set; }
        public ICollection<OrderedService> OrderedServices { get; set; } 
    }
}