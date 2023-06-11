using System.Windows;
using System.Windows.Controls;

namespace ModernCalculator.MVVM.View.CustomControls
{
    /// <summary>
    /// Interaction logic for Button_BasicNum.xaml
    /// </summary>
    public partial class Button_BasicNum : UserControl
    {
        public static readonly DependencyProperty ValueNumberProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(Button_BasicNum), 
                new PropertyMetadata(0));

        public int Value
        {
            get { return (int)GetValue(ValueNumberProperty); }
            set { SetValue(ValueNumberProperty, value); }
        }

        public static readonly RoutedEvent Click_RoutedEvent = EventManager.RegisterRoutedEvent(nameof(EventClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Button_BasicNum));
        public event RoutedEventHandler EventClick
        {
            add { AddHandler(Click_RoutedEvent, value); }
            remove { RemoveHandler(Click_RoutedEvent, value); }
        }

        public Button_BasicNum()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(Click_RoutedEvent));
        }
    }
}
