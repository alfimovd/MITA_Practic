using System.ComponentModel.Composition;
using Mita.Mvvm.ViewModels;

namespace ADService.Operator
{
    [Export(typeof(IViewModelManager<IChildViewModel>))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class ViewModelManager : ChildViewModelManager
    {
    }
}
