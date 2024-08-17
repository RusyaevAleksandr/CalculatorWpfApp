using System.Windows;

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

        private int ResultNumber;

        private string Sign;

        private void AddingNumber(int digit)
        {
            if (Sign == String.Empty && FirstDigit == 0)
            {
                FirstDigit = digit;
                resultLabel.Content = FirstDigit;
            }            
            else
            {
                resultLabel.Content = null;
                SecondDigit = digit;
                resultLabel.Content = SecondDigit;
                if (Sign == "/" && SecondDigit == 0)
                {
                    resultLabel.Content = "Ошибка!";
                }
            }
        }

        private void CleaningData()
        {
            Sign = String.Empty;
            FirstDigit = 0; 
            SecondDigit = 0;
            ResultNumber = 0;
        }

        private void DigitSevenButton_Click(object sender, RoutedEventArgs e)
        {
            AddingNumber(7);
        }

        private void DigitEightButton_Click(object sender, RoutedEventArgs e)
        {
            AddingNumber(8);
        }

        private void DigitNineButton_Click(object sender, RoutedEventArgs e)
        {
            AddingNumber(9);
        }

        private void SumTextButton_Click(object sender, RoutedEventArgs e)
        {
            Sign = "+";
        }

        private void DigitFourButton_Click(object sender, RoutedEventArgs e)
        {
            AddingNumber(4);
        }

        private void DigitFiveButton_Click(object sender, RoutedEventArgs e)
        {
            AddingNumber(5);
        }

        private void DigitSixButton_Click(object sender, RoutedEventArgs e)
        {
            AddingNumber(6);
        }

        private void SubtractButton_Click(object sender, RoutedEventArgs e)
        {
            Sign = "-";
        }

        private void DigitOneButton_Click(object sender, RoutedEventArgs e)
        {
            AddingNumber(1);
        }

        private void DigitTwoButton_Click(object sender, RoutedEventArgs e)
        {
            AddingNumber(2);
        }

        private void DigitThreeButton_Click(object sender, RoutedEventArgs e)
        {
            AddingNumber(3);
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            Sign = "*";
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            CleaningData();
            resultLabel.Content = null;
        }

        private void DigitZeroButton_Click(object sender, RoutedEventArgs e)
        {
            AddingNumber(0);
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            switch (Sign)
            {
                case "+":
                    ResultNumber = FirstDigit + SecondDigit;
                    resultLabel.Content = ResultNumber;
                    Sign = String.Empty;
                    break;
                case "-":
                    ResultNumber = FirstDigit - SecondDigit;
                    resultLabel.Content = ResultNumber;
                    Sign = String.Empty;
                    break;
                case "*":
                    ResultNumber = FirstDigit * SecondDigit;
                    resultLabel.Content = ResultNumber;
                    Sign = String.Empty;
                    break;
                case "/":
                    ResultNumber = FirstDigit / SecondDigit;
                    resultLabel.Content = ResultNumber;
                    Sign = String.Empty;
                    break;
            }
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            Sign = "/";
        }
    }
}