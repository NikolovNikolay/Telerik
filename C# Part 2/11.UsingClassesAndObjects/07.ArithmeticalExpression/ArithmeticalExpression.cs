using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class ArithmeticalExpression
{
    static List<char> operators = new List<char>() { '+', '-', '*', '/' };
    static List<string> functions = new List<string>() { "ln", "sqrt", "pow" };
    static List<char> brackets = new List<char>() { '(', ')' };

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine();

        string trimmedInput = TrimInput(input);
        Queue<string> ShuntingYardQueue = ProcessTokens(trimmedInput);
        Console.WriteLine(ReversePolishNotation(ShuntingYardQueue)); 
    }

    static string ReversePolishNotation(Queue<string> queue)
    {
        List<string> operate = new List<string>() { "+", "-", "*", "/" };
        var stack = new Stack<string>();
        var list = queue.ToList();
        for (int i = 0; i < list.Count; i++)
        {
            if (!operate.Contains(list[i]) && !functions.Contains(list[i]))
            {
                stack.Push(list[i]);
            }

            if (list[i] == "+")
            {
                if (stack.Count < 2)
                {
                    Console.WriteLine("nqma dostatychen broi argumenti");
                    throw new ArgumentException();
                }
                else
                {
                    double firstValue = double.Parse(stack.Pop());
                    double secondValue = double.Parse(stack.Pop());
                    stack.Push((firstValue + secondValue).ToString());
                }
            }

            if (list[i] == "-")
            {
                if (stack.Count < 2)
                {
                    Console.WriteLine("nqma dostatychen broi argumenti");
                    throw new ArgumentException();
                }
                else
                {
                    double firstValue = double.Parse(stack.Pop());
                    double secondValue = double.Parse(stack.Pop());
                    stack.Push((secondValue - firstValue).ToString());
                }
            }

            if (list[i] == "/")
            {
                if (stack.Count < 2)
                {
                    Console.WriteLine("nqma dostatychen broi argumenti");
                    throw new ArgumentException();
                }
                else
                {
                    double firstValue = double.Parse(stack.Pop());
                    double secondValue = double.Parse(stack.Pop());
                    stack.Push((secondValue / firstValue).ToString());
                }
            }

            if (list[i] == "*")
            {
                if (stack.Count < 2)
                {
                    Console.WriteLine("nqma dostatychen broi argumenti");
                    throw new ArgumentException();
                }
                else
                {
                    double firstValue = double.Parse(stack.Pop());
                    double secondValue = double.Parse(stack.Pop());
                    stack.Push((secondValue * firstValue).ToString());
                }
            }

            if (list[i] == "ln")
            {
                if (stack.Count < 1)
                {
                    Console.WriteLine("nqma dostatychen broi argumenti");
                    throw new ArgumentException();
                }
                else
                {
                    double firstValue = double.Parse(stack.Pop());
                    stack.Push((Math.Log(firstValue)).ToString());
                }
            }


            if (list[i] == "sqrt")
            {
                if (stack.Count < 1)
                {
                    Console.WriteLine("nqma dostatychen broi argumenti");
                    throw new ArgumentException();
                }
                else
                {
                    double firstValue = double.Parse(stack.Pop());
                    
                    stack.Push((Math.Sqrt(firstValue)).ToString());
                }
            }

        }
        string result = "";
        if (stack.Count == 1)
        {
            result = stack.Pop();
        }

        return result;

            
    }

    

    static Queue<string> ProcessTokens(string trimmedInput)
    {
        Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();
        var number = new StringBuilder();

        for (int i = 0; i < trimmedInput.Length; i++)
        {
            
            if (trimmedInput[i] >= '0' && trimmedInput[i] <= '9' || trimmedInput[i] == '-')
            {
                if (trimmedInput[i] == '-' && i == 0 || trimmedInput[i]=='-' && trimmedInput[i-1] == ',' || 
                    trimmedInput[i] == '-' && trimmedInput[i-1] == '(')
                {
                    number.Append(trimmedInput[i]);
                    continue;
                }

                //if (trimmedInput[i] == '-')
                //{
                //    number.Length--;
                //}
                while (trimmedInput[i] >= '0' && trimmedInput[i] <= '9' || trimmedInput[i] == '.')
                    {

                        number.Append(trimmedInput[i]);
                        if (i + 1 < trimmedInput.Length)
                            i++;
                        else
                            break;

                    }
                    queue.Enqueue(number.ToString());
                    number.Clear();
                
            }

            // if token is function
            if (i + 1 < trimmedInput.Length)
            {
                if (functions.Contains(trimmedInput.Substring(i, 2).ToLower()))
                {
                    stack.Push(trimmedInput.Substring(i, 2).ToLower());
                }
            }

            if (i + 2 < trimmedInput.Length)
            {
                if (functions.Contains(trimmedInput.Substring(i, 3).ToLower()))
                {
                    stack.Push(trimmedInput.Substring(i, 3).ToLower());
                } 
            }

            if (i + 3 < trimmedInput.Length)
            {
                if (functions.Contains(trimmedInput.Substring(i, 4).ToLower()))
                {
                    stack.Push(trimmedInput.Substring(i, 4).ToLower());
                } 
            }

            // if token is operator
            if (operators.Contains(trimmedInput[i]) && i!= 0)
            {
                if (stack.Count != 0)
	            {
		            if (operators.Contains(stack.Peek()[0]) && (CalcPrecedence(trimmedInput[i]) <= CalcPrecedence(stack.Peek()[0])))
                    {
                        queue.Enqueue(stack.Pop());
                    } 
	            }

                stack.Push(trimmedInput[i].ToString());
            }
            // if token is separator
            if (trimmedInput[i] == ',')
            {
                while (stack.Count > 0 && stack.Peek() != "(")
                {
                    queue.Enqueue(stack.Pop());

                    if (stack.Count == 1 && stack.Peek() != "(")
                    {
                        Console.WriteLine("Misplaced separator or mismatched parenthesis!");
                        throw new ArgumentException();
                    }
                }

               
            }

            if (trimmedInput[i] == '(')
            {
                stack.Push(trimmedInput[i].ToString());
            }

            if (trimmedInput[i] == ')')
            {
                while (stack.Peek() != "(" && stack.Count != 0)
                {
                    queue.Enqueue(stack.Pop());
                }
                //stack.Pop();

                if (stack.Count != 0)
                {
                    if (functions.Contains(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    } 
                }

                if (stack.Count == 1 && stack.Peek() != "(")
                {
                    Console.WriteLine("Misplaced separator or mismatched parenthesis!");
                    throw new ArgumentException();
                }
                stack.Pop();
            }
        }

        while (stack.Count != 0)
        {
            if(brackets.Contains(stack.Peek()[0]))
            {
                Console.WriteLine("Missmatched parenthese!");
                throw new ArgumentException();
            }
            queue.Enqueue(stack.Pop());
        }

        return queue;
    }

    static string TrimInput(string input)
    {
        string trimmedInput = input.Replace(" ", string.Empty);
        trimmedInput = trimmedInput.Trim();

        return trimmedInput;
    }

    static int CalcPrecedence(char op)
    {
        if (op == '+' || op == '-')
        {
            return 1;
        }

        if (op == '*' || op == '/')
        {
            return 2;
        }

        return 0;
    }
}