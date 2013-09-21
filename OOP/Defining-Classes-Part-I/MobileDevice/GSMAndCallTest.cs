using System;
using System.Linq;

namespace MobileDevice
{
    // Current class tests the GSM and Call classes
    class GSMAndCallTest
    {
        static void Main(string[] args)
        {   
            // testing GSM - creating array of GSM objects
            Console.WriteLine("------------------------TESTING GSM CLASS -------------------");
            GSM[] array = new GSM[] {
                                        new GSM("7250", "Nokia", 250, "Atanas Ivanov"),
                                        new GSM("GT-I9100", "Samsung", 680),
                                        new GSM("Xperia Z", "Sony", 800, "Momchil Georgiev"),
                                        new GSM("Galaxy S4", "Samsung", 1000, "Some Person", new Battery(BatteryType.NiMh),new Display(15,16000000))
            };

            // Printing the information of the mobile devices in the array
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString());
            }

            // Printing the information about the static iPhone
            Console.WriteLine("..:: Static Member iPhone info ::..");
            Console.WriteLine("Manufacturer: "+GSM.iPhone.Manufacturer);
            Console.WriteLine("Model: "+GSM.iPhone.Model);
            Console.WriteLine("Price: " +GSM.iPhone.Price);
            Console.WriteLine();


            // testing call history
            Console.WriteLine("------------------------TESTING CALL CLASS -------------------");

            GSM myPhone = new GSM("Galaxy S2", "Samsung", 980, "Kolio Kolev", new Battery(BatteryType.LiIon, "IOP456", 500, 250), new Display(640, 16000000));

            myPhone.AddCallToHistory("123456789", 890);
            myPhone.AddCallToHistory("348732478", 345);
            myPhone.AddCallToHistory("*88", 123);

            // Print initial call history
            Console.WriteLine("..:: Call History ::..");
            foreach (var call in myPhone.CallHistory)
            {
                Console.WriteLine("{0} {1} {2}", call.DateAndTime, call.PhoneNumber, call.Duration);
            }

            // Print total costs of calls in history
            Console.WriteLine("..:: Total Costs ::..");
            Console.WriteLine(myPhone.CalculateTotalPriceOfCalls(0.37));

            // Total costs after removing the call with the longes duration
            Console.WriteLine("..:: New Total Costs ::..");
            myPhone.RemoveCallsFromHistoryViaDuration(890);
            Console.WriteLine(myPhone.CalculateTotalPriceOfCalls(0.37));

            // Print the new call history, after the call is removed
            Console.WriteLine("..:: New Call History ::..");
            foreach (var call in myPhone.CallHistory)
            {
                Console.WriteLine("{0} {1} {2}", call.DateAndTime, call.PhoneNumber, call.Duration);
            }

            // Clearing the call history and printing it(suppose nothing is expected to be printed)
            myPhone.ClearCallHistory();
            foreach (var call in myPhone.CallHistory)
            {
                Console.WriteLine("{0} {1} {2}", call.DateAndTime, call.PhoneNumber, call.Duration);
            }
        }
    }
}
