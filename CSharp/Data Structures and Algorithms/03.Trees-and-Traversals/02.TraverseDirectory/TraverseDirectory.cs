/*Write a program to traverse the directory C:\WINDOWS and 
 * all its subdirectories recursively and to display all
 * files matching the mask *.exe. Use the class System.IO.Directory.
*/

namespace TraverseDirectory
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;

    class TraverseDirectory
    {
        static void Main()
        {
            DirectoryInfo winRoot = new DirectoryInfo(@"C:/Windows");
            Queue<DirectoryInfo> dirs = new Queue<DirectoryInfo>();
            int exeCounter = 0;
            var output = new StringBuilder();

            
                dirs.Enqueue(winRoot);
                while (dirs.Count > 0)
                {
                    try
                    {
                        var activeDirectory = dirs.Dequeue();
                        var files = activeDirectory.EnumerateFiles();
                        var subDirs = activeDirectory.EnumerateDirectories();

                        foreach (var file in files)
                        {
                            if (file.Extension == ".exe")
                            {
                                exeCounter++;
                                Console.WriteLine(file.Name+file.Extension);
                            }
                        }

                        foreach (var dir in subDirs)
                        {
                            dirs.Enqueue(dir);
                        }
                    }
                    catch (UnauthorizedAccessException uae)
                    {
                        Console.WriteLine(uae.Message);
                    }
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Total {0} matches for the mask *.exe in C:\\Windows", exeCounter);
                Console.ResetColor();
            
        }
    }
}
