using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADService.DataAccess.Model;


namespace ADService.DataAccess
{
    public class Db : DbContext
    {
        public Db() : base("ADServiceDb") { }

        public IDbSet<Branch> Branches { get; set; }
        public IDbSet<BranchService> BranchServices { get; set; }
        public IDbSet<Client> Clients { get; set; }
        public IDbSet<Component> Components { get; set; }
        public IDbSet<ComponentCategory> ComponentCategories { get; set; }
        public IDbSet<Manager> Managers { get; set; }
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<OrderedComponent> OrderedComponents { get; set; }
        public IDbSet<OrderedService> OrderedServices { get; set; }
        public IDbSet<Service> Services { get; set; }
        public IDbSet<ServiceCategory> ServiceCategories { get; set; }
        public IDbSet<Supplier> Suppliers { get; set; }
        public IDbSet<SupplierComponent> SupplierComponents { get; set; }
        public IDbSet<Transport> Transports { get; set; }
        public IDbSet<TransportManufacturer> TransportManufacturers { get; set; }
        public IDbSet<TransportModel> TransportModels { get; set; }
        public IDbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
