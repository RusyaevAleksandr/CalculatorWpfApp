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

        private void Digit_Button_Click(object sender, RoutedEventArgs e)
        {
            var DigitButton = (Button)(sender);

            var digit = DigitButton.Content as string;

            resultLabel.Content += digit;
        }
    }
}