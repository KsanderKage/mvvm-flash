using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Events;
using MVVM.Events;
using MVVM.Views;

namespace ModuleTest
{
    public class TestFlashRegistrationModule : IModule
    {
        private IUnityContainer _container;

        public TestFlashRegistrationModule(IUnityContainer container)
        {
            _container = container;
        }

        public void Initialize()
        {
            _container.Resolve<IEventAggregator>().GetEvent<FunctionEvent>().Publish(_container.Resolve<FunctionEventParameter>().Init("shell.showview", _container.Resolve<TestFlashView>()));
        }
    }
}
