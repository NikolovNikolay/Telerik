
namespace TreeBuilding
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class Folder
    {
        public string Name { get; set; }
        public Folder[] ChildFolders { get; set; }
        public File[] Files { get; set; }

        public Folder(string name, Folder[] subFolders, File[] files)
        {
            this.Name = name;
            this.ChildFolders = subFolders;
            this.Files = files;
        }

        public BigInteger CalculateFileSize()
        {
            BigInteger totalSize = 0;

            foreach (var file in Files)
            {
                totalSize += file.Size;
            }


            foreach (var directory in ChildFolders)
            {
                totalSize += directory.CalculateFileSize();
            }

            return totalSize;
        }
    }
}
