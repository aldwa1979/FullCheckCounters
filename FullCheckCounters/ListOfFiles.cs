using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCheckCounters
{
    class ListOfFiles
    {
        public List<FileInfo> Files ()
        {
            ListOfDirectories listOfDirectories = new ListOfDirectories();
            var fullPathForFiles = listOfDirectories.Directories();
            List<FileInfo> filesList = new List<FileInfo>(); 

            foreach (var path in fullPathForFiles)
            {
                DirectoryInfo directory = new DirectoryInfo(path.FullName);
                filesList.AddRange(directory.GetFiles());
            }

            return filesList;
        }
    }
}
