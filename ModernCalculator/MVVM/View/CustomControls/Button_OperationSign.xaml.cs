using System.Windows;
using System.Windows.Controls;

namespace ModernCalculator.MVVM.View.CustomControls
{
    /// <summary>
    /// Interaction logic for Button_OperationSign.xaml
    /// </summary>
    public partial class Button_OperationSign : UserControl
    {
        public string Operation
        {
            get { return (string)GetValue(OperationProperty); }
            set { SetValue(OperationProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Operation.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OperationProperty =
            DependencyProperty.Register("Operation", typeof(string), typeof(Button_OperationSign), new PropertyMetadata(string.Empty));

        public static readonly RoutedEvent Click_RoutedEvent = EventManager.RegisterRoutedEvent(nameof(EventClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Button_OperationSign));
        public event RoutedEventHandler EventClick
        {
            add { AddHandler(Click_RoutedEvent, value); }
            remove { RemoveHandler(Click_RoutedEvent, value); }
        }

        public Button_OperationSign()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(Click_RoutedEvent));
        }
    }
}
