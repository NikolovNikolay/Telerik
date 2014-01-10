/** A text file phones.txt holds information about people, their town and phone number.
 * Duplicates can occur in people names, towns and phone numbers. Write a program to read
 * the phones file and execute a sequence of commands given in the file commands.txt:
      find(name) – display all matching records by given name (first, middle, last or nickname)
      find(name, town) – display all matching records by given name and town
*/

namespace PhoneNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;
    using System.IO;

    class PhoneNumbers
    {
        static void Main()
        {
            var reader = new StreamReader("../../phones.txt");
            var phonebook = new MultiDictionary<string, MultiDictionary<string, string>>(false);
            FillEntriesInDictionary(phonebook, reader);

            reader = new StreamReader("../../commands.txt");
            ReadAndExecuteCommand(phonebook, reader);
        }

        private static void FillEntriesInDictionary(MultiDictionary<string, MultiDictionary<string, string>> phonebook, StreamReader reader)
        {
            string currentLine = reader.ReadLine();
            while (currentLine != null)
            {
                var elements = currentLine.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string name = elements[0].Trim();
                string town = elements[1].Trim();
                string phone = elements[2].Trim();

                if (phonebook.ContainsKey(name))
                {
                    var nameWithinPhonebook = phonebook[name].First();
                    if (nameWithinPhonebook.ContainsKey(town))
                    {
                        nameWithinPhonebook[town].Add(phone);
                    }
                    else
                    {
                        nameWithinPhonebook.Add(town, phone);
                    }
                }
                else
                {
                    phonebook.Add(name, new MultiDictionary<string, string>(false));
                    var nameWithinPhonebook = phonebook[name].First();
                    nameWithinPhonebook.Add(town, phone);
                }

                currentLine = reader.ReadLine();
            }
        }

        private static void ReadAndExecuteCommand(MultiDictionary<string, MultiDictionary<string, string>> phonebook, StreamReader reader)
        {
            string currentLine = reader.ReadLine();

            while (currentLine != null)
            {
                var findObject = currentLine.Substring(currentLine.IndexOf('(') + 1, currentLine.IndexOf(')') - currentLine.IndexOf('(') - 1);
                var separateObjects = findObject.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                
                if (separateObjects.Length == 1)
                {
                    var searchedName = separateObjects[0].Trim();
                    var resultNames = from n in phonebook where n.Key == searchedName select n;
                    foreach (var resultName in resultNames)
                    {
                        Console.WriteLine("{0}: ", resultName.Key);
                        Console.WriteLine(new string('-', 7));
                        foreach (var elementPair in resultName.Value)
                        {
                            foreach (var town in elementPair)
                            {
                                foreach (var number in town.Value)
                                {
                                    Console.WriteLine("{0} -> {1}", town.Key, number);
                                }
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    var searchedName = separateObjects[0].Trim();
                    var searchedTown = separateObjects[1].Trim();

                    var resultNames = from k in phonebook where k.Key == searchedName select k;
                    foreach (var name in resultNames)
                    {
                        Console.WriteLine("{0}:", name.Key);
                        Console.WriteLine(new string('-', 7));
                        foreach (var elementPair in name.Value)
                        {
                            var resultLocation = from rez in elementPair where rez.Key == searchedTown select rez;
                            foreach (var town in resultLocation)
                            {
                                foreach (var number in town.Value)
                                {
                                    Console.WriteLine("{0} -> {1}", town.Key, number);
                                }
                            }
                        }
                        Console.WriteLine();
                    }
                }
                currentLine = reader.ReadLine();
            }
        }
    }
}
