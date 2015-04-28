using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADService.DataAccess;
using ADService.DataAccess.Model;
using Mita.DataAccess;
using Mita.Core;

namespace ADService.Operator.ViewModel
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]

    public class MainViewModel : ChildViewModel
    {
        private Manager _manager;
        private ICollection<Order> _orders;
        private ICollection<BranchService> _services;
        private ICollection<SupplierComponent> _components;

        public MainViewModel()
        {
            //SearchCommand = new DelegateCommand(() => Task.Run((Action)Search));
            //CreateOrderCommand = new DelegateCommand((Action)CreateOrder);
        }
        public Task InitializeAsync(int userId)
        {
            return Task.Run(() => Initialize(userId));
        }

        [Import(RequiredCreationPolicy = CreationPolicy.NonShared)]
        private IRepositoryProvider RepositoryProvider { get; set; }


        public void Initialize(int userId)
        {
            using (StartOperation())
            {
                _manager = RepositoryProvider.GetRepository<Manager>()
                    .GetAll(e => e.Branch, e => e.User)
                    .First(e => e.Id == userId);
                Title = _manager.Branch.Title;
            }
        }
    }
}
