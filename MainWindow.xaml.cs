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

        private string firstNumber = String.Empty;

        private string secondNumber = String.Empty;

        private string resultNumber = String.Empty;

        private string operationSign = String.Empty;

        private void Result_Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(operationSign) || String.IsNullOrEmpty(secondNumber))
            {
                MessageBox.Show("Вы не указали числа и операцию над ними!");
                return;
            }

            var firstOperand = Convert.ToInt32(firstNumber);                  
            var secondOperand = Convert.ToInt32(secondNumber);

            resultNumber = String.Empty;

            switch (operationSign)
            {
                case "+": resultNumber = (firstOperand + secondOperand).ToString();
                    break;
                case "-": resultNumber = (firstOperand - secondOperand).ToString();
                    break;
                case "x": resultNumber = (firstOperand * secondOperand).ToString(); 
                    break;
                case "/":
                    if (secondOperand != 0) 
                    {
                        resultNumber = (firstOperand / secondOperand).ToString();
                    }
                    else
                    {
                        MessageBox.Show("На ноль делить нельзя!");
                        return;
                    }
                     
                    break;
            }

            firstNumber = resultNumber;

            operationSign = String.Empty;
            secondNumber = String.Empty;

            UpdateResultLabel();
        }

        private void Digit_Button_Click(object sender, RoutedEventArgs e)
        {
            var DigitButton = (Button)(sender);

            var digit = DigitButton.Content as string;

            if (String.IsNullOrEmpty(operationSign))
            {
                firstNumber += Convert.ToInt32(digit);
            }
            else
            {
                secondNumber += Convert.ToInt32(digit);
            }

            UpdateResultLabel();
        }

        private void UpdateResultLabel()
        {
            resultLabel.Content = firstNumber + operationSign + secondNumber;
        }

        private void Operation_Button_Click(object sender, RoutedEventArgs e)
        {
            var operationButton = (Button)(sender);

            var sign = operationButton.Content as string;

            if (String.IsNullOrEmpty(firstNumber))
            {
                if (sign == "-")
                {
                    firstNumber += sign;
                }
                else
                {
                    MessageBox.Show("Нельзя выполнить такую операцию!");
                    return;
                }
            }
            else
            {
                if (firstNumber == "-")
                {
                    MessageBox.Show("Укажите число!");
                    return;
                }
                operationSign = sign;
            }

            UpdateResultLabel();
        }

        private void Reset_Button_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = String.Empty;
            secondNumber = String.Empty;
            operationSign = String.Empty;

            UpdateResultLabel();
        }
    }
}