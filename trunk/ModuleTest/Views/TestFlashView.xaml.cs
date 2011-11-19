using System.Windows.Controls;
using Microsoft.Practices.Unity;
using MVVM.ViewModels;

namespace MVVM.Views
{
    /// <summary>
    /// Interaction logic for TestFlashView.xaml
    /// </summary>
    public partial class TestFlashView : UserControl
    {
        public TestFlashView(IUnityContainer container)
        {
            InitializeComponent();

            DataContext = container.Resolve<TestFlashViewModel>().Init(container);
        }
    }
}
