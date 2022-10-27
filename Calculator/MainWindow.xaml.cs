using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double number1 = 0;
        double number2 = 0;
        string operation = "";

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (operation == "") {
                number1 = (number1 * 10) + 1;
                Output.Content = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                Output.Content = number2.ToString();
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                Output.Content = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                Output.Content = number2.ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                Output.Content = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                Output.Content = number2.ToString();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                Output.Content = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                Output.Content = number2.ToString();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                Output.Content = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                Output.Content = number2.ToString();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                Output.Content = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                Output.Content = number2.ToString();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                Output.Content = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                Output.Content = number2.ToString();
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                Output.Content = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                Output.Content = number2.ToString();
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                Output.Content = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                Output.Content = number2.ToString();
            }
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                Output.Content = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                Output.Content = number2.ToString();
            }
        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            operation = "+";
            Output.Content = "+";
        }

        private void Button_Click_Minus(object sender, RoutedEventArgs e)
        {
            operation = "-";
            Output.Content = "-";
        }

        private void Button_Click_Multiply(object sender, RoutedEventArgs e)
        {
            operation = "*";
            Output.Content = "*";
        }

        private void Button_Click_Divide(object sender, RoutedEventArgs e)
        {
            operation = "/";
            Output.Content = "/";
        }

        private void Button_Result(object sender, RoutedEventArgs e)
        {
            number2 = double.Parse((string)Output.Content);
            switch (operation) {
                case "+":
                    Output.Content = (number1 + number2).ToString();
                    number1 = double.Parse((string)Output.Content);
                    break;

                case "-":
                    Output.Content = (number1 - number2).ToString();
                    number1 = double.Parse((string)Output.Content);
                    break;

                case "*":
                    Output.Content = (number1 * number2).ToString();
                    number1 = double.Parse((string)Output.Content);
                    break;

                case "/":
                    if (number2 != 0) {
                        Output.Content = (number1 / number2).ToString();
                        number1 = double.Parse((string)Output.Content);
                    }
                    else
                    {
                        Output.Content = "Cannot divide by zero";
                        number1 = 0;
                        number2 = 0;
                    }
                    break;
            }
            number2 = 0;
        }
        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            Output.Content = "";
            operation = "";
            number1 = 0;
            number2 = 0;
        }

    }
}
