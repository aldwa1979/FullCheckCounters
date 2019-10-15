using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FullCheckCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            FullCheckExport fullCheckExport = new FullCheckExport();
            fullCheckExport.ExportFileWithNameOfFile();
            fullCheckExport.ExportFileFromSecondField();
            fullCheckExport.ExportFileFromFieldWithDate();
        }
    }
}