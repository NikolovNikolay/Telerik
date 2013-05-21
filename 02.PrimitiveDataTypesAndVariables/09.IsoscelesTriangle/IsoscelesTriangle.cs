/*Write a program that prints an isosceles 
 * triangle of 9 copyright symbols ©. Use Windows 
 * Character Map to find the Unicode code of the ©
 * symbol. Note: the © symbol may be displayed incorrectly.
*/

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        char copyright = '\u00A9';
       

        Console.WriteLine(@"       {0}
      {0}{0}{0}
     {0}{0}{0}{0}{0}", copyright);
        Console.WriteLine();

        char space = ' ';
        char at = '\u00a9';
        char[,] arr = { 
                         {space,space,at,space,space},
                         {space,at,at,at,space},
                         {at,at,at,at,at}
                      };
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0}",arr[i,j]);
            }
            Console.WriteLine();
        }
    } 
}

