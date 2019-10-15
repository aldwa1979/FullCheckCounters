using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCheckCounters
{
    class ListOfDirectories
    {
        public List<DirectoryInfo> Directories()
        {
            string path = @"D:\Repozytoria\FullChecks\Import\Checks";

            if (Directory.Exists(path))
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                var directoryList = directory.GetDirectories().ToList();

                return directoryList;
            }

            else { Console.WriteLine("There is no {path} folder"); }

            return null;
        }
    }
}