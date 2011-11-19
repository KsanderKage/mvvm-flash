using System.Windows;
using System;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            StartupContainer();
        }

        private void StartupContainer()
        {
            try
            {
                Bootstrapper bootstrapper = new Bootstrapper();
                bootstrapper.Run();
                bootstrapper.ShowDefaultView();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
