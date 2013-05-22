/** Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	0  "Zero"
	273  "Two hundred seventy three"
	400  "Four hundred"
	501  "Five hundred and one"
	711  "Seven hundred and eleven"
*/

using System;

class NumberToText
{
    static void Main()
    {
        Console.Write("Input number 0-999: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int digit = number % 10;
        int hundred = (number / 10) % 10;
        int thousand = (number / 100) % 10;
        string digits = "";
        string hundreds = "";
        string thousands = "";

        if (number >= 0 && number <= 999)
        {
            if (thousand == 1)
            {
                thousands = "One hundred";
            }
            else if (thousand == 2)
            {
                thousands = "Two hundred";
            }
            else if (thousand == 3)
            {
                thousands = "Four hundred";
            }
            else if (thousand == 4)
            {
                thousands = "Four hundred";
            }
            else if (thousand == 5)
            {
                thousands = "Five hundred";
            }
            else if (thousand == 6)
            {
                thousands = "Six hundred";
            }
            else if (thousand == 7)
            {
                thousands = "Seven hundred";
            }
            else if (thousand == 8)
            {
                thousands = "Eight hundred";
            }
            else if (thousand == 9)
            {
                thousands = "Nine hundred";
            }
            if (hundred == 1)
            {
                if (digit == 1)
                {
                    hundreds = "and eleven";
                }
                if (digit == 0)
                {
                    hundreds = "and ten";
                }
                if (digit == 2)
                {
                    hundreds = "and twelve";
                }
                if (digit == 3)
                {
                    hundreds = "and thirteen";
                }
                if (digit == 4)
                {
                    hundreds = "and fourteen";
                }
                if (digit == 5)
                {
                    hundreds = "and fifteen";
                }
                if (digit == 6)
                {
                    hundreds = "and sixteen";
                }
                if (digit == 7)
                {
                    hundreds = "and seventeen";
                }
                if (digit == 8)
                {
                    hundreds = "and eighteen";
                }
                if (digit == 9)
                {
                    hundreds = "and nineteen";
                }
            }
            if (thousand == 0)
            {
                if (hundred == 1)
                {
                    if (digit == 1)
                    {
                        hundreds = "Eleven";
                    }
                    if (digit == 0)
                    {
                        hundreds = "Ten";
                    }
                    if (digit == 2)
                    {
                        hundreds = "Twelve";
                    }
                    if (digit == 3)
                    {
                        hundreds = "Thirteen";
                    }
                    if (digit == 4)
                    {
                        hundreds = "Fourteen";
                    }
                    if (digit == 5)
                    {
                        hundreds = "Fifteen";
                    }
                    if (digit == 6)
                    {
                        hundreds = "Sixteen";
                    }
                    if (digit == 7)
                    {
                        hundreds = "Seventeen";
                    }
                    if (digit == 8)
                    {
                        hundreds = "Eighteen";
                    }
                    if (digit == 9)
                    {
                        hundreds = "Nineteen";
                    }
                }
            }
            if (hundred == 2)
            {
                if (digit == 0 && thousand == 0 || thousand == 0)
                {
                    hundreds = "Twenty";
                }
                else if (thousand != 0 | hundred != 0)
                {
                    hundreds = "and twenty";
                }
            }
            if (hundred == 3)
            {
                if (digit == 0 && thousand == 0 || thousand == 0)
                {
                    hundreds = "Thirty";
                }
                else if (thousand != 0 | hundred != 0)
                {
                    hundreds = "and thirty";
                }
            }
            if (hundred == 4)
            {
                if (digit == 0 && thousand == 0 || thousand == 0)
                {
                    hundreds = "Fourty";
                }
                else if (thousand != 0 | hundred != 0)
                {
                    hundreds = "and fourty";
                }
            }
            if (hundred == 5)
            {
                if (digit == 0 && thousand == 0 || thousand==0)
                {
                    hundreds = "Fifthy";
                }
                else if (thousand != 0 | hundred != 0)
                {
                    hundreds = "and fifthy";
                }
            }
            if (hundred == 6)
            {
                if (digit == 0 && thousand == 0 || thousand == 0)
                {
                    hundreds = "Sixty";
                }
                else if (thousand != 0 | hundred != 0)
                {
                    hundreds = "and sixty";
                }
            }
            if (hundred == 7)
            {
                if (digit == 0 && thousand == 0 || thousand == 0)
                {
                    hundreds = "Seventy";
                }
                else if (thousand != 0 | hundred != 0)
                {
                    hundreds = "and seventy";
                }
            }
            if (hundred == 8)
            {
                if (digit == 0 && thousand == 0 || thousand == 0)
                {
                    hundreds = "Eighty";
                }
                else if (thousand != 0 | hundred != 0)
                {
                    hundreds = "and eighty";
                }
            }
            if (hundred == 9)
            {
                if (digit == 0 && thousand == 0 || thousand == 0)
                {
                    hundreds = "Ninety";
                }
                else if (thousand != 0 | hundred != 0)
                {
                    hundreds = "and ninety";
                }
            }
            if (hundred == 0 && thousand != 0)
            {
                if (digit == 1)
                {
                    hundreds = "and one";
                } if (digit == 2)
                {
                    hundreds = "and two";
                } if (digit == 3)
                {
                    hundreds = "and three";
                } if (digit == 4)
                {
                    hundreds = "and four";
                } if (digit == 5)
                {
                    hundreds = "and five";
                } if (digit == 6)
                {
                    hundreds = "and six";
                } if (digit == 7)
                {
                    hundreds = "and seven";
                } if (digit == 8)
                {
                    hundreds = "and eight";
                } if (digit == 9)
                {
                    hundreds = "and nine";
                }
            }
            else
            {
                if (hundred != 0 && hundred != 1)
                {
                    if (digit == 1)
                    {
                        digits = "one";
                    } if (digit == 2)
                    {
                        digits = "two";
                    } if (digit == 3)
                    {
                        digits = "three";
                    } if (digit == 4)
                    {
                        digits = "four";
                    } if (digit == 5)
                    {
                        digits = "five";
                    } if (digit == 6)
                    {
                        digits = "six";
                    } if (digit == 7)
                    {
                        digits = "seven";
                    } if (digit == 8)
                    {
                        digits = "eight";
                    } if (digit == 9)
                    {
                        digits = "nine";
                    }
                }
                if (thousand == 0 && hundred == 0)
                {
                    if (digit == 1)
                    {
                        digits = "One";
                    } if (digit == 2)
                    {
                        digits = "Two";
                    } if (digit == 3)
                    {
                        digits = "Three";
                    } if (digit == 4)
                    {
                        digits = "Four";
                    } if (digit == 5)
                    {
                        digits = "Five";
                    } if (digit == 6)
                    {
                        digits = "Six";
                    } if (digit == 7)
                    {
                        digits = "Seven";
                    } if (digit == 8)
                    {
                        digits = "Eight";
                    } if (digit == 9)
                    {
                        digits = "Nine";
                    }
                }
                if (thousand == 0 && hundred == 0 && digit == 0)
                {
                    digits = "Zero";
                }
            }
            Console.WriteLine("The syntax of the number is: {0} {1} {2}", thousands, hundreds, digits);
        }
        else
        {
            Console.WriteLine("Please choose a number from 0 to 999");
        }
    }
}
