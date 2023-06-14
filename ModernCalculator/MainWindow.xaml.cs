using ModernCalculator.MVVM.View.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

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

        private string string_term;
        public string PropertyString_term
        {
            get { return string_term; }
            set
            {
                string_term = value;
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
                    PropertyCurrent_operand -= OPERAND_LIST_SIZE;
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

            Update_TermString();
        }

        private void Click_Operation(object sender, RoutedEventArgs event_args)
        {
            Button_OperationSign button_sender = (Button_OperationSign)sender;

            operation_sign = button_sender.Operation[0];
            PropertyString_term += button_sender.Operation[0];

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

            Update_TermString();
        }

        public void Click_TerminateLastNum(object sender, RoutedEventArgs event_args)
        {
            string modify_value = PropertyValue_enter.ToString();

            PropertyValue_enter = Convert.ToInt32(modify_value.Substring(0, modify_value.Length - 1));
            operand_info[PropertyCurrent_operand] = PropertyValue_enter;
        }

        private void Click_TerminateAll(object sender, RoutedEventArgs event_args)
        {
            PropertyValue_enter = 0;
            for (int a = 0; a < OPERAND_LIST_SIZE; a++)
                operand_info[a] = 0;

            operation_sign = '\0';
        }

        private void Click_AboutButton(object sender, RoutedEventArgs event_args)
        {
            const double time_animation = 0.5; 

            Button_Interface button_sender = (Button_Interface)sender;
            Panel.SetZIndex(border_AboutMenu, button_sender.ExitState);

            if (button_sender.ExitState == 1)
                Animate_panel(true, false);
            else if (button_sender.ExitState == -1)
                Animate_panel(false, true);

            void Animate_panel(bool ToPanel, bool ToMain)
            {
                border_AboutMenu.BeginAnimation(UIElement.OpacityProperty, new DoubleAnimation(Convert.ToDouble(ToPanel), TimeSpan.FromSeconds(time_animation)));
                border_AboutMenu.IsEnabled = ToPanel;

                grid_UserMenu.BeginAnimation(UIElement.OpacityProperty, new DoubleAnimation(Convert.ToDouble(ToMain), TimeSpan.FromSeconds(time_animation)));
                grid_UserMenu.IsEnabled = ToMain;
            }
        }

        private void Update_TermString()
        {
            for (int a = 0; a < OPERAND_LIST_SIZE; a++)
            {
                PropertyString_term += operand_info[a].ToString();
                if (a < OPERAND_LIST_SIZE - 1)
                    PropertyString_term += operation_sign;
            }
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Site_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Image image_sender = (Image)sender;
            switch (image_sender.Name)
            {
                case "icon_GitHub": Process.Start("https://github.com/FrenzyCode64"); break;
                case "icon_Steam": Process.Start("https://steamcommunity.com/profiles/76561198931354092"); break;
                case "icon_Youtube": Process.Start("https://www.youtube.com/channel/UC1eDs-42u2UZ9A0ykDFXl4g"); break;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
