using Microsoft.Practices.Unity;

namespace MVVM.ViewModels
{
    public class TestFlashViewModel : ViewModelBase
    {
        public TestFlashViewModel(IUnityContainer container)
            : base(container)
        { 
        
        }

        virtual public TestFlashViewModel Init(IUnityContainer container)
        {
            Movie = @"C:\Flash\flash.swf";
            Play = true;
            return this;
        }

        string _movie;
        public string Movie
        {
            get { return _movie; }
            set { OnPropertyChanged(ref _movie, value, "Movie"); }
        }

        bool _play;
        public bool Play
        {
            get { return _play; }
            set { OnPropertyChanged(ref _play, value, "Play"); }
        }

    }
}
