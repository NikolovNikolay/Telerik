namespace _01.Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading;
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

    public partial class MainWindow : Window
    {
        private const char PlusOperator = '+';
        private const char MinusOperator = '-';
        private const char MultiplyOperator = '*';
        private const char DivisionOperator = '/';
        private const char PowerFunction = '^';
        private const char SqrtFunction = 'V';
        private const char LeftParenthesis = '(';
        private const char RightParenthesis = ')';
        private const char FloatingPoint = '.';
        private const char Comma = ',';
        private const string ExceptionIVIE = "Insufficient values in expression!";
        private const string ExceptionTMVE = "Too many values in expression!";
        private const string ExceptionMSMP = "Misplased seperator or mismatched parenthense";
        private static double? firstNumber;
        private static List<string> operators = new List<string>() { "+", "-", "*", "/" };
        private static List<string> functions = new List<string>() { "Ln", "^", "V" };

        public MainWindow()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        private void Calculate(string str)
        {
            try
            {
                this.DigitsContainerTextBox.Text = this.ReversedPolish(this.ReadTokens(str));
            }
            catch (Exception)
            {
            }
        }

        private string ReversedPolish(Queue<string> readTokens)
        {
            Stack<string> stack = new Stack<string>();
            double value;

            while (readTokens.Count > 0)
            {
                string element = readTokens.Peek();
                if (double.TryParse(element, out value))
                {
                    stack.Push(value.ToString());
                    readTokens.Dequeue();
                }
                else
                {
                    readTokens.Dequeue();
                    if (operators.Contains(element))
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException(ExceptionIVIE);
                        }
                        else
                        {
                            if (element == PlusOperator.ToString())
                            {
                                double result = double.Parse(stack.Pop()) + double.Parse(stack.Pop());
                                stack.Push(result.ToString());
                            }
                            else if (element == MinusOperator.ToString())
                            {
                                double first = double.Parse(stack.Pop());
                                double second = double.Parse(stack.Pop());
                                double result = second - first;
                                stack.Push(result.ToString());
                            }
                            else if (element == MultiplyOperator.ToString())
                            {
                                double result = double.Parse(stack.Pop()) * double.Parse(stack.Pop());
                                stack.Push(result.ToString());
                            }
                            else if (element == DivisionOperator.ToString())
                            {
                                double first = double.Parse(stack.Pop());
                                double second = double.Parse(stack.Pop());
                                double result = second / first;
                                stack.Push(result.ToString());
                            }
                        }
                    }
                    else
                    {
                        if (element == PowerFunction.ToString())
                        {
                            if (stack.Count < 2)
                            {
                                throw new ArgumentException(ExceptionIVIE);
                            }
                            else
                            {
                                double first = double.Parse(stack.Pop());
                                double second = double.Parse(stack.Pop());
                                double result = Math.Pow(second, first);
                                stack.Push(result.ToString());
                            }
                        }
                        else if (element == SqrtFunction.ToString())
                        {
                            if (stack.Count < 1)
                            {
                                throw new ArgumentException(ExceptionIVIE);
                            }
                            else
                            {
                                double result = Math.Sqrt(double.Parse(stack.Peek()));
                                stack.Pop();
                                stack.Push(result.ToString());
                            }
                        }
                    }
                }
            }

            string atEnd = string.Empty;

            if (stack.Count == 1)
            {
                atEnd = stack.Peek();
            }
            else
            {
                throw new ArgumentException(ExceptionTMVE);
            }

            return atEnd;
        }

        private Queue<string> ReadTokens(string str)
        {
            Queue<string> queue = new Queue<string>();
            Stack<string> stack = new Stack<string>();
            var number = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                char token = str[i];

                // if token is a number ( works for negative and positive)
                if ((token >= '0' && token <= '9' || token == FloatingPoint) || (i == 0 && token == MinusOperator) ||
                     (token == MinusOperator && str[i - 1] == LeftParenthesis) || (token == '-' && str[i - 1] == Comma))
                {
                    number.Append(token);
                    if (i + 1 < str.Length)
                    {
                        if (!(str[i + 1] >= '0' && str[i + 1] <= '9') && str[i + 1] != FloatingPoint)
                        {
                            queue.Enqueue(number.ToString());
                            number.Clear();
                        }
                    }
                }

                if ((token >= '0' && token <= '9' && i == str.Length - 1))
                {
                    number.Length--;
                    number.Append(token);
                    queue.Enqueue(number.ToString());
                    number.Clear();
                }

                // if token is '('
                if (token == LeftParenthesis)
                {
                    stack.Push(token.ToString());
                }

                // if token is ')'
                if (token == RightParenthesis)
                {
                    if (stack.Count == 0 || !stack.Contains(LeftParenthesis.ToString()))
                    {
                        throw new ArgumentException(ExceptionMSMP);
                    }

                    while (stack.Peek() != LeftParenthesis.ToString())
                    {
                        queue.Enqueue(stack.Pop());
                    }

                    stack.Pop();
                    if (stack.Count != 0 && functions.Contains(stack.Peek().ToString()))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }

                // if token is a function
                if (token == PowerFunction)
                {
                    stack.Push(PowerFunction.ToString());
                }

                if (token == SqrtFunction)
                {
                    stack.Push(SqrtFunction.ToString());
                }

                // if token is argument separator - ,
                if (token == Comma)
                {
                    if (stack.Count == 0 || !stack.Contains(LeftParenthesis.ToString()))
                    {
                        throw new ArgumentException(ExceptionMSMP);
                    }

                    while (stack.Peek() != LeftParenthesis.ToString())
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }

                // if token is operator
                if (operators.Contains(token.ToString()))
                {
                    while (stack.Count != 0 && operators.Contains(stack.Peek().ToString()) && OperatorPrecedence(token) <= OperatorPrecedence(stack.Peek()[0]))
                    {
                        queue.Enqueue(stack.Pop());
                    }

                    if (i > 0)
                    {
                        if (str[i - 1] != Comma && str[i - 1] != LeftParenthesis)
                        {
                            stack.Push(token.ToString());
                        }
                    }
                }
            }

            // Pop the remaining operators off the stack (if avilable)
            if (stack.Count > 0)
            {
                while (stack.Count != 0)
                {
                    if (stack.Peek() == LeftParenthesis.ToString() || stack.Peek() == RightParenthesis.ToString())
                    {
                        throw new ArgumentException(ExceptionMSMP);
                    }

                    queue.Enqueue(stack.Pop());
                }
            }

            return queue;
        }

        private string TrimInput(string str)
        {
            string result = string.Empty;
            result = str.Replace(" ", string.Empty);
            result = result.Trim();
            return result;
        }

        private int OperatorPrecedence(char op)
        {
            if (op == PowerFunction)
            {
                return 1;
            }

            if (op == PlusOperator || op == MinusOperator)
            {
                return 2;
            }
            else if (op == MultiplyOperator || op == DivisionOperator)
            {
                return 3;
            }

            return 0;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            this.DigitsContainerTextBox.Text += (sender as Button).Content;
        }

        private void OnDeleteButtonClick(object sender, RoutedEventArgs e)
        {
            if (this.DigitsContainerTextBox.Text.Length >= 1)
            {
                this.DigitsContainerTextBox.Text = this.DigitsContainerTextBox.Text.Substring(0, this.DigitsContainerTextBox.Text.Length - 1);
            }
        }

        private void OnClearButtonClick(object sender, RoutedEventArgs e)
        {
            this.DigitsContainerTextBox.Text = string.Empty;
        }

        private void OnEqualsButtonPress(object sender, RoutedEventArgs e)
        {
            string expression = this.DigitsContainerTextBox.Text;
            Calculate(expression);
        }

        private void OnToggleSignButtonClick(object sender, RoutedEventArgs e)
        {
            double currentNumber = double.Parse(this.DigitsContainerTextBox.Text);
            this.DigitsContainerTextBox.Text = (currentNumber * -1).ToString();
            firstNumber = currentNumber * -1;
        }

        private void DetermineFirstNumber()
        {
            string first = this.DigitsContainerTextBox.Text;
            try
            {
                firstNumber = double.Parse(first);
            }
            catch (Exception)
            {
                this.DigitsContainerTextBox.Text = "Invalid op. Pls clear.";
                return;
            }

            this.DigitsContainerTextBox.Text = string.Empty;
        }
    }
}
