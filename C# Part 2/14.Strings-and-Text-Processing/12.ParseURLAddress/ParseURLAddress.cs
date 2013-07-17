/*Write a program that parses an URL address given 
 * and extracts from it the [protocol], [server] and [resource] elements. 
 * For example from the URL http://www.devbg.org/forum/index.php the following 
 * information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"

*/

using System;
using System.Text;

class ParseURLAddress
{
    static string ReturnProtocol(StringBuilder sb, string address, int index)
    {
        while (true)
        {
            if (address[index] != ':')
            {
                sb.Append(address[index]);
            }
            else
            {
                break;
            }
            index++;
        }
        string protocol = sb.ToString();
        sb.Clear();

        return protocol;
    }

    static void ReturnServerAndRecourse(StringBuilder sb, string address)
    {
        int startIndex = address.IndexOf(':') + 3;
        int element = startIndex;
        for (int i = startIndex; i < address.Length; i++)
        {
            element++;
            if (address[i] != '/')
                sb.Append(address[i]);
            else
                break;
        }
        string server = sb.ToString();
        sb.Clear();
        Console.WriteLine("[server] = \"{0}\"",server);

        for (int i = element; i < address.Length; i++)
        {
            sb.Append(address[i]);
        }
        string resource = sb.ToString();

        Console.WriteLine("[recourse] = \"{0}\"", resource);
    }

    static void Main()
    {
        //string address = "http://www.devbg.org/forum/index.php";
        string address = Console.ReadLine();
        int index = 0;

        StringBuilder sb = new StringBuilder();

        Console.WriteLine("[protocol] = \"{0}\"", ReturnProtocol(sb, address, index));
        ReturnServerAndRecourse(sb, address);
    }

}
