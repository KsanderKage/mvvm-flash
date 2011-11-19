using System.Windows.Forms;

namespace WPFControlLibrary
{
    public partial class FlashWrapper : UserControl
    {
        public FlashWrapper()
        {
            InitializeComponent();
        }

        public void LoadMovie(string movie)
        {
            axShockwaveFlash.Movie = movie;
        }

        public void Play()
        {
            axShockwaveFlash.Play();
        }

        public void Stop()
        {
            axShockwaveFlash.Stop();
        }
    }
}
