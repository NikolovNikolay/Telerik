using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VersionAttribute
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            CarSampleClass newCar = new CarSampleClass(SampleCarsEnumMaker.Citroen, SampleCarsEnumColor.Silver, 75);
            Type type = typeof(CarSampleClass);
            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("Current version is: {0} ", attr.Version);

            }
        }
    }
}
