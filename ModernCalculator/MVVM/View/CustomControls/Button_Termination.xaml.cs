using System.Windows;
using System.Windows.Controls;

namespace ModernCalculator.MVVM.View.CustomControls
{
    /// <summary>
    /// Interaction logic for Button_Termination.xaml
    /// </summary>
    public partial class Button_Termination : UserControl
    {
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
    }
}
