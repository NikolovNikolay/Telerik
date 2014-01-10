/*Write a program that calculates the value of given arithmetical 
expression. The expression can contain the following elements only:
Real numbers, e.g. 5, 18.33, 3.14159, 12.6
Arithmetic operators: +, -, *, / (standard priorities)
Mathematical functions: ln(x), sqrt(x), pow(x,y)
Brackets (for changing the default priorities)
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

class ArithmeticalExpression
{
    static List<string> operators = new List<string>() { "+", "-", "*", "/" };
    static List<string> functions = new List<string>() { "ln", "pow", "sqrt" };

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = "";
        Calculate(input);
    }

    static void Calculate(string str)
    {
        while (true)
        {
            try
            {
                str = Console.ReadLine().ToLower();
                if (str == "end")
                {
                    break;
                }

                Console.WriteLine(ReversedPolish(ReadTokens(TrimInput(str))));
                Console.WriteLine(new string('-', 15));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(new string('-', 15));

            }
        }
    }

    static string ReversedPolish(Queue<string> readTokens)
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
                        throw new ArgumentException("Insufficient values in expression!");
                    }
                    else
                    {
                        if (element == "+")
                        {
                            double result = double.Parse(stack.Pop()) + double.Parse(stack.Pop());
                            stack.Push(result.ToString());
                        }
                        else if (element == "-")
                        {
                            double first = double.Parse(stack.Pop());
                            double second = double.Parse(stack.Pop());
                            double result = second - first;
                            stack.Push(result.ToString());
                        }
                        else if (element == "*")
                        {
                            double result = double.Parse(stack.Pop()) * double.Parse(stack.Pop());
                            stack.Push(result.ToString());
                        }
                        else if (element == "/")
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
                    if (element == "pow")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Insufficient values in expression!");
                        }
                        else
                        {
                            double first = double.Parse(stack.Pop());
                            double second = double.Parse(stack.Pop());
                            double result = Math.Pow(second, first);
                            stack.Push(result.ToString());
                        }
                    }
                    else if (element == "sqrt")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Insufficient values in expression!");
                        }
                        else
                        {
                            double result = Math.Sqrt(double.Parse(stack.Peek()));
                            stack.Pop();
                            stack.Push(result.ToString());
                        }
                    }
                    else if (element == "ln")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Insufficient values in expression!");
                        }
                        else
                        {
                            double result = Math.Log(double.Parse(stack.Peek()));
                            stack.Pop();
                            stack.Push(result.ToString());
                        }
                    }
                }
            }
        }

        string atEnd = "";

        if (stack.Count == 1)
        {
            atEnd = stack.Peek();
        }
        else
        {
            throw new ArgumentException("Too many valuew in expression!");
        }

        return atEnd;
    }

    static Queue<string> ReadTokens(string str)
    {
        Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();
        var number = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            char token = str[i];
            // if token is a number ( works for negative and positive)
            if ((token >= '0' && token <= '9' || token == '.') || (i == 0 && token == '-') ||
                 (token == '-' && str[i - 1] == '(') || (token == '-' && str[i - 1] == ','))
            {
                number.Append(token);
                if (i + 1 < str.Length)
                {
                    if (!(str[i + 1] >= '0' && str[i + 1] <= '9') && str[i + 1] != '.')
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
            if (token == '(')
            {
                stack.Push(token.ToString());
            }

            // if token is ')'
            if (token == ')')
            {
                if (stack.Count == 0 || !stack.Contains("("))
                {
                    throw new ArgumentException("Misplased seperator or mismatched parenthense");
                }
                while (stack.Peek() != "(")
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
            if (i + 2 < str.Length)
                if (functions.Contains(str.Substring(i, 2)))
                    stack.Push(str.Substring(i, 2));

            if (i + 2 < str.Length)
                if (functions.Contains(str.Substring(i, 3)))
                    stack.Push(str.Substring(i, 3));

            if (i + 3 < str.Length)
                if (functions.Contains(str.Substring(i, 4)))
                    stack.Push(str.Substring(i, 4));

            // if token is argument separator - ,
            if (token == ',')
            {
                if (stack.Count == 0 || !stack.Contains("("))
                {
                    throw new ArgumentException("Misplased seperator or mismatched parenthense");
                }
                while (stack.Peek() != "(")
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
                    if (str[i - 1] != ',' && str[i - 1] != '(')
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
                if (stack.Peek() == "(" || stack.Peek() == ")")
                {
                    throw new ArgumentException("Mismatched parenthenses");
                }
                queue.Enqueue(stack.Pop());
            }

        }

        return queue;
    }

    static string TrimInput(string str)
    {
        string result = "";

        result = str.Replace(" ", string.Empty);
        result = result.Trim();
        return result;
    }

    static int OperatorPrecedence(char op)
    {
        if (op == '+' || op == '-')
        {
            return 1;
        }
        else if (op == '*' || op == '/')
        {
            return 2;
        }

        return 0;
    }
}