using System.Windows;
using System.Windows.Controls;

namespace ModernCalculator.MVVM.View.CustomControls
{
    /// <summary>
    /// Interaction logic for Button_Result.xaml
    /// </summary>
    public partial class Button_Result : UserControl
    {
        public static readonly RoutedEvent Click_RoutedEvent = EventManager.RegisterRoutedEvent(nameof(EventClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Button_Result));
        public event RoutedEventHandler EventClick
        {
            add { AddHandler(Click_RoutedEvent, value); }
            remove { RemoveHandler(Click_RoutedEvent, value); }
        }

        public Button_Result()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(Click_RoutedEvent));
        }
    }
}
