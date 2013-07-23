using System;
using System.Linq;

class MatrixUI
{
    static void Main()
    {
        Matrix first = new Matrix(2, 2);
        first[0, 0] = 1;
        first[1, 1] = -12;
        Matrix second = new Matrix(2, 2);
        second[0, 1] = 2;
        second[1, 1] = 24;

        Matrix sum = first + second;
        Matrix subtract = first - second;
        Matrix multiply = first * second;

        Console.WriteLine(sum.ToString());
        Console.WriteLine(subtract.ToString());
        Console.WriteLine(multiply.ToString());
    }
}
