using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TenantsManager.Model1;

namespace TenantsManager
{
    class MainViewModel
    {
        private TenantRepository _repository = new TenantRepository();

        public ICollection<Tenant> Tenants { get; set; }

        public Tenant SelectedTenant { get; set; }

        public MainViewModel()
        {
            Tenants = _repository.GetAll().ToList();
        }
    }
}
