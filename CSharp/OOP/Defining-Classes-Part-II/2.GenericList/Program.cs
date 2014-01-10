using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main()
        {
            GenericList<int> id = new GenericList<int>(5);
            for (int i = 0; i < 999; i++)
            {
                id.AddElement(i);
            }

            id.AddElementAt(678, 9045);
            id.AddElementAt(1000, -1);

            Console.WriteLine(id.Min());
            Console.WriteLine(id.Max());
            Console.WriteLine(id.ToString());
            
           
        }

        
    }
}
