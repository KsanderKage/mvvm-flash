using System.Windows.Controls;

namespace WPFControlLibrary
{
    /// <summary>
    /// Interaction logic for FlashWPF.xaml
    /// </summary>
    public partial class FlashWPF : UserControl
    {
        public FlashWPF()
        {
            InitializeComponent();
        }

        public void LoadMovie(string movie)
        {
            FlashPlayer.LoadMovie(movie);
        }

        public void Play(bool value)
        {
            if (value)
                FlashPlayer.Play();
            else
                FlashPlayer.Stop();
        }
    }
}
