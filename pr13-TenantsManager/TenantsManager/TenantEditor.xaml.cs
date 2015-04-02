using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TenantsManager.Model;

namespace TenantsManager
{
    /// <summary>
    /// Логика взаимодействия для TenantEditor.xaml
    /// </summary>
    public partial class TenantEditor : UserControl
    {
        public TenantEditor()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty TenantProperty = DependencyProperty.Register(
            "Tenant", typeof (Tenant), typeof (TenantEditor), new PropertyMetadata(default(Tenant), OnTenantChanged));

        private static void OnTenantChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var oldTenant = e.OldValue as Tenant;
            var newTenant = e.NewValue as Tenant;

            string oldName = oldTenant == null ? "NULL" : oldTenant.Name;
            string newName = newTenant == null ? "NULL" : newTenant.Name;

            Debug.WriteLine("Tenant changed from {0} to {1}", oldName, newName);
        }

        public Tenant Tenant
        {
            get { return (Tenant)GetValue(TenantProperty); }
            set { SetValue(TenantProperty, value); }
        }

        public static readonly DependencyProperty IsReadOnlyProperty = DependencyProperty.Register(
            "IsReadOnly", typeof (bool), typeof (TenantEditor), new PropertyMetadata(false, OnIsReadOnlyChanged));

        private static void OnIsReadOnlyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var editor = e.NewValue as bool;
        }

        public bool IsReadOnly
        {
            get { return (bool)GetValue(IsReadOnlyProperty); }
            set { SetValue(IsReadOnlyProperty, value); }
        }

        public static readonly DependencyProperty IsEditableProperty = DependencyProperty.Register(
            "IsEditable", typeof(bool), typeof(TenantEditor), new PropertyMetadata(true));

        public bool IsEditable
        {
            get { return (bool)GetValue(IsEditableProperty); }
            private set { SetValue(IsEditableProperty, value); }
        }
    }
}
