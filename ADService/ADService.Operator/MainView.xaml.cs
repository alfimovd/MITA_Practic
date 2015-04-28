using System.ComponentModel.Composition;
using Mita.Mvvm.Views;

namespace ADService.Operator
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>
    [Export("MainView", typeof(IView))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class MainView : IView
    {
        public MainView()
        {
            InitializeComponent();
        }
    }
}
