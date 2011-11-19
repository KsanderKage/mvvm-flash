using System.Windows;
using Microsoft.Practices.Unity;
using MVVM.ViewModels;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : Window
    {
        private IUnityContainer _container;

        public Shell(IUnityContainer container)
        {
            InitializeComponent();
            _container = container;

            DataContext = _container.Resolve<ShellViewModel>();
        }
    }
}
