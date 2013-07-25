/*Write a program that extracts from given XML file all the text without the tags.*/

using System;
using System.Linq;
using System.Text;
using System.IO;

class ExtractWithoutTags
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"../../someXML.xml"))
        {
            int element = reader.Read();
            char start = '>';
            char end = '<';
            StringBuilder sb = new StringBuilder();

            while (element != -1 )
            {
                if ((char)element == start)
                {
                    int internalElement = element;
                    internalElement = reader.Read();
                    while (internalElement != end && internalElement != -1)
                    {
                        if (internalElement != '\n' && internalElement != '\r')
                        {
                            sb.Append((char)internalElement);
                        }
                        internalElement = reader.Read();
                    }

                    if (!string.IsNullOrEmpty(sb.ToString()))
                    {
                        Console.WriteLine(sb.ToString().TrimEnd('\n'));
                    }
                }
                sb.Clear();
                element = reader.Read();
            }
        }
    }
}
