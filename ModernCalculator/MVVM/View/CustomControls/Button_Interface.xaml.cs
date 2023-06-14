using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ModernCalculator.MVVM.View.CustomControls
{
    /// <summary>
    /// Interaction logic for Button_Interface.xaml
    /// </summary>
    public partial class Button_Interface : UserControl
    {
        public static readonly DependencyProperty ExitStateProperty =
            DependencyProperty.RegisterAttached("ExitState", typeof(int), typeof(Button_Interface), new PropertyMetadata(0));

        public int ExitState
        {
            get { return (int)GetValue(ExitStateProperty); }
            set { SetValue(ExitStateProperty, value); }
        }

        public static readonly DependencyProperty TextElProperty =
            DependencyProperty.RegisterAttached("TextField", typeof(string), typeof(Button_Interface), new PropertyMetadata(string.Empty));

        public string TextField
        {
            get { return (string)GetValue(TextElProperty); }
            set { SetValue(TextElProperty, value); }
        }

        public static readonly DependencyProperty BackgroundElProperty =
            DependencyProperty.RegisterAttached("BackGroundColor", typeof(Brush), typeof(Button_Interface), new PropertyMetadata(Brushes.Transparent));

        public Brush BackGroundColor
        {
            get { return (Brush)GetValue(BackgroundElProperty); }
            set { SetValue(BackgroundElProperty, value); }
        }

        public static readonly DependencyProperty ForegroundElProperty =
            DependencyProperty.RegisterAttached("ForeGroundColor", typeof(Brush), typeof(Button_Interface), new PropertyMetadata(Brushes.Transparent));

        public Brush ForeGroundColor
        {
            get { return (Brush)GetValue(ForegroundElProperty); }
            set { SetValue(ForegroundElProperty, value); }
        }

        public static readonly RoutedEvent Click_RoutedEvent = EventManager.RegisterRoutedEvent(nameof(EventClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Button_Interface));
        public event RoutedEventHandler EventClick
        {
            add { AddHandler(Click_RoutedEvent, value); }
            remove { RemoveHandler(Click_RoutedEvent, value); }
        }

        public Button_Interface()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(Click_RoutedEvent));
        }
    }
}
