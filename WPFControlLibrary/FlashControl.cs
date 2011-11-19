using System.Windows;
using System.Windows.Controls;

namespace WPFControlLibrary
{
    public class FlashControl : Control
    {
        static FlashControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlashControl), new FrameworkPropertyMetadata(typeof(FlashControl)));
        }


        public FlashControl()
        {
            FlashPlayer = new FlashWPF();
        }

        //*****************************************************************************************

        //Movie property definition

        public static readonly DependencyProperty MovieProperty = DependencyProperty.RegisterAttached("Movie", typeof(string), typeof(FlashControl), new PropertyMetadata(MovieChanged));

        private static void MovieChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as FlashControl).Movie = (string)e.NewValue;
        }

        //Play movie property definition
        public static readonly DependencyProperty PlayProperty = DependencyProperty.RegisterAttached("Play", typeof(bool), typeof(FlashControl), new PropertyMetadata(PlayChanged));

        private static void PlayChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as FlashControl).Play = (bool)e.NewValue;
        }

        //Flash player WindowFormHost
        public static readonly DependencyProperty FlashPlayerProperty = DependencyProperty.RegisterAttached("FlashPlayer", typeof(FlashWPF), typeof(FlashControl), new PropertyMetadata(FlashPlayerChanged));

        private static void FlashPlayerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as FlashControl).FlashPlayer = (FlashWPF)e.NewValue;
        }

        //*****************************************************************************************

        public string Movie
        {
            get { return (string)this.GetValue(MovieProperty); }
            set 
            { 
                this.SetValue(MovieProperty, value);
                FlashPlayer.LoadMovie(value);
            }
        }

        public bool Play
        {
            get { return (bool)this.GetValue(PlayProperty); }
            set 
            { 
                this.SetValue(PlayProperty, value);
                FlashPlayer.Play(value);
            }
        }

        public FlashWPF FlashPlayer
        {
            get { return (FlashWPF)this.GetValue(FlashPlayerProperty); }
            set { this.SetValue(FlashPlayerProperty, value); }
        }
    }
}
