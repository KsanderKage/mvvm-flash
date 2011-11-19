using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Events;
namespace MVVM.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        protected IUnityContainer _container;
        protected IEventAggregator _eventAggregator;

        //*****************************************************************************************

        public ViewModelBase(IUnityContainer container)
        {
            _container = container;
            _eventAggregator = _container.Resolve<IEventAggregator>();
        }

        #region property changed functionality

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// helper function to change a property, raise the onproperty changed event and raise execute changed for DelegateCommand
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <param name="updateThese"></param>
        /// <returns></returns>
        protected virtual bool OnPropertyChanged<T>(ref T field, T value, params object[] updateThese)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                OnPropertyChanged(updateThese);
                return true;
            }
            return false;
        }

        virtual protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        virtual protected void OnPropertyChanged(params object[] updateThese)
        {
            updateThese.Where(property => property is string).ForEach(property => OnPropertyChanged(property as string));
        }

        #endregion

    }
}
