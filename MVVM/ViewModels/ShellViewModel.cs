using Microsoft.Practices.Unity;
using MVVM.Events;

namespace MVVM.ViewModels
{
    public class ShellViewModel:ViewModelBase
    {
        public ShellViewModel(IUnityContainer container)
            : base(container)
        {
            _eventAggregator.GetEvent<FunctionEvent>().Subscribe(FunctionEventHandler);
        }

        //*****************************************************************************************

        protected void FunctionEventHandler(FunctionEventParameter param)
        {
            if (param != null && param.ViewName == "shell.showview")
                CurrentView = param.DataIn;
        }


        //*****************************************************************************************

        object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { OnPropertyChanged(ref _currentView, value, "CurrentView"); }
        }
    }
}
