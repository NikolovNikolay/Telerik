/*Write a program that enters file name 
 * along with its full file path (e.g. C:\WINDOWS\win.ini), 
 * reads its contents and prints it on the console.
 * Find in MSDN how to use System.IO.File.ReadAllText(…).
 * Be sure to catch all possible exceptions and print user-friendly 
 * error messages.
*/

using System;
using System.IO;
using System.Security;

class ReadAndPrintAFile
{
    static void Main()
    {
        try
        {
            // the file given is in the solution's main folder. To test catching exceptions change the name of the file, change the 
            // path and so on ... IMPROVISE :)

            string someText = File.ReadAllText(@"../../../sampleText.txt");
            Console.WriteLine(someText);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("File is null");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("File contains a zero-length string, contains only white space, or contains one or more invalid characters");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The file s path or filename is too long");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The path is invalid");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found");
        }
        catch (IOException)
        {
            Console.WriteLine("There was na error opening the file");
        }
        
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("There are access permission issues with the file");
        }
        
        catch (NotSupportedException)
        {
            Console.WriteLine("The path of the file is in an invalid format");
        }
        catch (SecurityException)
        {
            Console.WriteLine("There are access permission issues with the file");
        }
    }
}
