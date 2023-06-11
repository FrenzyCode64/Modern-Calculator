using System.Windows;
using System.Windows.Controls;

namespace ModernCalculator.MVVM.View.CustomControls
{
    /// <summary>
    /// Interaction logic for Button_Termination.xaml
    /// </summary>
    public partial class Button_Termination : UserControl
    {
        public static readonly RoutedEvent Click_RoutedEvent = EventManager.RegisterRoutedEvent(nameof(EventClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Button_Termination));
        public event RoutedEventHandler EventClick
        {
            add { AddHandler(Click_RoutedEvent, value); }
            remove { RemoveHandler(Click_RoutedEvent, value); }
        }

        public static readonly DependencyProperty OperationNumberProperty =
            DependencyProperty.Register("Operation", typeof(string), typeof(Button_Termination),
                new PropertyMetadata(string.Empty));

        public string Operation
        {
            get { return (string)GetValue(OperationNumberProperty); }
            set { SetValue(OperationNumberProperty, value); }
        }

        public Button_Termination()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(Click_RoutedEvent));
        }
    }
}
