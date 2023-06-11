using ModernCalculator.MVVM.View.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace ModernCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private int value_enter;
        public int PropertyValue_enter
        {
            get { return value_enter; }
            set 
            { 
                value_enter = value;
                NotifyPropertyChanged();
            }
        }

        private int current_operand = 0;
        public int PropertyCurrent_operand
        {
            get { return current_operand; }
            set 
            { 
                current_operand = value;
                if (PropertyCurrent_operand >= OPERAND_LIST_SIZE)
                    PropertyCurrent_operand = PropertyCurrent_operand - OPERAND_LIST_SIZE;
            }
        }


        private const int OPERAND_LIST_SIZE = 2;
        private int[] operand_info = new int[OPERAND_LIST_SIZE];

        private char operation_sign = '\0';

        private void Click_BasicNum(object sender, RoutedEventArgs event_args)
        {
            Button_BasicNum button_sender = (Button_BasicNum)sender;

            PropertyValue_enter = Convert.ToInt32(PropertyValue_enter.ToString() + button_sender.Value.ToString());
            operand_info[PropertyCurrent_operand] = PropertyValue_enter;
        }

        private void Click_Operation(object sender, RoutedEventArgs event_args)
        {
            Button_OperationSign button_sender = (Button_OperationSign)sender;
            operation_sign = button_sender.Operation[0];

            PropertyCurrent_operand++;
            PropertyValue_enter = 0;
        }

        private void Click_GetResult(object sender, RoutedEventArgs event_args)
        {
            PropertyValue_enter = 0;
            for (int a = 0; a < OPERAND_LIST_SIZE - 1; a++)
            {
                switch (operation_sign)
                {
                    case '+': PropertyValue_enter += (operand_info[a] + operand_info[a + 1]); break;
                    case '-': PropertyValue_enter += (operand_info[a] - operand_info[a + 1]); break;
                    case '*': PropertyValue_enter += (operand_info[a] * operand_info[a + 1]); break;
                    case '/': PropertyValue_enter += (operand_info[a] / operand_info[a + 1]); break;
                }
            }

            for (int a = 0; a < OPERAND_LIST_SIZE; a++)
                operand_info[a] = 0;

            operand_info[0] = PropertyValue_enter;
            PropertyCurrent_operand++;
        }

        public void Click_TerminateLastNum(object sender, RoutedEventArgs event_args)
        {
            string modify_value = PropertyValue_enter.ToString();

            PropertyValue_enter = Convert.ToInt32(modify_value.Substring(0, modify_value.Length - 1));
            operand_info[PropertyCurrent_operand] = PropertyValue_enter;
        }

        private void Click_TerminateAll(object sender, RoutedEventArgs event_args)
        {
            PropertyCurrent_operand = 0;
            PropertyValue_enter = 0;

            operation_sign = '\0';
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
