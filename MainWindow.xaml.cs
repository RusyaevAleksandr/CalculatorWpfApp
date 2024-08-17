using System.Windows;
using System.Windows.Controls;

namespace CalculatorWpfApp
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

        private int FirstDigit;

        private int SecondDigit;

        private string ResultNumber;

        private void Result_Button_Click(object sender, RoutedEventArgs e)
        {
            string[] operations = new string[] {"+", "-", "x", "/"};

            string textLabel = resultLabel.Content.ToString();

            var elements = textLabel.Split(operations, StringSplitOptions.RemoveEmptyEntries);

            FirstDigit = Convert.ToInt32(elements[0]);
            SecondDigit = Convert.ToInt32(elements[1]);

            if (textLabel.Contains("+"))
            {
                ResultNumber = (FirstDigit + SecondDigit).ToString();
            }
            else if (textLabel.Contains("-"))
            {
                ResultNumber = (FirstDigit - SecondDigit).ToString();
            }
            else if (textLabel.Contains("x"))
            {
                ResultNumber = (FirstDigit * SecondDigit).ToString();
            }
            else if (textLabel.Contains("/"))
            {
                if (SecondDigit != 0)
                {
                    ResultNumber = (FirstDigit / SecondDigit).ToString();
                }
                else
                {
                    ResultNumber = "Ошибка!";
                }
            }

            resultLabel.Content = ResultNumber;
        }

        private void Digit_Button_Click(object sender, RoutedEventArgs e)
        {
            var DigitButton = (Button)(sender);

            var digit = DigitButton.Content as string;

            resultLabel.Content += digit;
        }

        private void Operation_Button_Click(object sender, RoutedEventArgs e)
        {
            var operationButton = (Button)(sender);

            var operation = operationButton.Content as string;

            resultLabel.Content += operation;
        }

        private void Reset_Button_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = String.Empty;
        }
    }
}