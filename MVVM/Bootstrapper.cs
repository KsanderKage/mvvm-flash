using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Events;

namespace MVVM
{
    class Bootstrapper : UnityBootstrapper
    {
        Shell _shell;

        public Bootstrapper()
        { 
        
        }

        protected override DependencyObject CreateShell()
        {
            _shell = Container.Resolve<Shell>();
            return _shell;
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            // Search the filesystem to find compatible modules
            return new DirectoryModuleCatalog() { ModulePath = @".\" };
        }

        protected override void ConfigureContainer()
        {
            Container.RegisterType<IEventAggregator, EventAggregator>(new ContainerControlledLifetimeManager());
            base.ConfigureContainer();
        }

        public void ShowDefaultView()
        {
            _shell.Show();
        }
    }
}
