using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> m1 = new Matrix<int>(4, 5);
            m1[0, 1] = 40;
            Matrix<int> m2 = new Matrix<int>(4, 5);
            m2[0, 1] = 20;

            var result= m1+m2;

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    Console.Write("{0,3} ", result[i,j]);
                }
                Console.WriteLine();
            }
           
        }
    }
}
