using Microsoft.Expression.Interactivity.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TenantsManager.Annotations;
using TenantsManager.Model;

namespace TenantsManager
{
    public class MainViewModel : INotifyPropertyChanged 
    {
        private TenantRepository _repository = new TenantRepository();
        private Tenant _selectedTenant;
        public bool ShowDelete { get; set; }
        public ICollection<Tenant> Tenands { get; set; }

        public Tenant SelectedTenant
        {
            get { return _selectedTenant; }
            set
            {
                if (Equals(value, _selectedTenant)) return;
                _selectedTenant = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            ReloadTenants();

            CreateTenantCommand = new ActionCommand(CreateTenant);
            AddNewTenantCommand = new ActionCommand(AddItemTenant);
            DeleteTenantCommand = new ActionCommand(DeleteTenant);
        }

        private void DeleteTenant()
        {
            _repository.Remove(SelectedTenant);
            SelectedTenant.IsDeleted = true;
            ReloadTenants();
            SelectedTenant = null;
        }

        public ActionCommand CreateTenantCommand { get; private set; }
        public ActionCommand AddNewTenantCommand { get; private set; }
        public ActionCommand DeleteTenantCommand { get; private set; }
        private void CreateTenant()
        {
            var tenant = new Tenant
            {
                Birthday = new DateTime(),
                Debt = 200,
                Name = "New tenant",
                IsNew = true
            };
            SelectedTenant = tenant;
        }

        private void AddItemTenant()
        {
            var tenant = SelectedTenant;
            _repository.Add(tenant);
            SelectedTenant = null;
            ReloadTenants();
            SelectedTenant = tenant;
        }

        private void ReloadTenants()
        {
            var tenantsQuery = _repository.GetAll();

            if (!ShowDelete)
                tenantsQuery = tenantsQuery.Where(t => !t.IsDeleted);

            Tenands = tenantsQuery.ToArray();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
