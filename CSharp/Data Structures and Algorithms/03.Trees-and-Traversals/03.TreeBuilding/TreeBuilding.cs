/*Define classes File { string name, int size } and Folder
 * { string name, File[] files, Folder[] childFolders } and
 * using them build a tree keeping all files and folders on 
 * the hard drive starting from C:\WINDOWS. Implement a method
 * that calculates the sum of the file sizes in given subtree
 * of the tree and test it accordingly. Use recursive DFS traversal.
*/

namespace TreeBuilding
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Globalization;

    class TreeBuilding
    {
        static void Main()
        {
            // Tree building process can taka e while (e.g. 10 seconds)
            DirectoryInfo rootDirectory = new DirectoryInfo(@"C:\Windows");
            var root = TreeBuilder(rootDirectory);
            Console.WriteLine("Recoursive tree building process is completed.");

            Console.WriteLine("The total file size vaule in {1} directory is {0} bytes.",root.CalculateFileSize(), rootDirectory.FullName);
        }

        private static Folder TreeBuilder(DirectoryInfo rootFolder)
        {
            string name = rootFolder.Name.ToString();
            List<File> subFiles = new List<File>();
            List<Folder> subFolders = new List<Folder>();

            try
            {
                var filesInRoot = rootFolder.EnumerateFiles();
                var dirsInRoot = rootFolder.EnumerateDirectories();
                foreach (var file in filesInRoot)
                {
                    subFiles.Add(new File(file.Name, (int)file.Length));
                }

                foreach (var folder in dirsInRoot)
                {
                    subFolders.Add(TreeBuilder(folder));
                }
            }
            catch (UnauthorizedAccessException uae)
            {
                //Console.WriteLine(uae.Message);
            }

            return new Folder(name, subFolders.ToArray(), subFiles.ToArray());
        }
    }
}
