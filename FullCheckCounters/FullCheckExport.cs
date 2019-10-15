using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCheckCounters
{
    class FullCheckExport
    {
        string path1 = @"D:\Repozytoria\FullChecks\Export\ExportWithNameOfFiles.csv";
        string path2 = @"D:\Repozytoria\FullChecks\Export\ExportFileFromSecondField.csv";
        string path3 = @"D:\Repozytoria\FullChecks\Export\ExportFileFromFieldWithDate.csv";

        public void ExportFileWithNameOfFile()
        {
            FullCheckImport fullCheckImport = new FullCheckImport();
            var finalList = fullCheckImport.ImportFile_Second_Field();

            using (StreamWriter sw = new StreamWriter(path1))
            {
                foreach (var item in finalList)
                {
                    sw.WriteLine(($"{item.Name};{item.FullCheckCounter};{item.FullChecksDate};{item.Type}"));
                }
            }

            Console.WriteLine(@"Data is in D:\Repozytoria\FullChecks\Export\ExportWithNameOfFiles.csv");
        }

        public void ExportFileFromSecondField()
        {
            FullCheckImport fullCheckImport = new FullCheckImport();
            var finalList = fullCheckImport.ImportFile_Second_Field().OrderBy(s => s.Type).Select(y => new { CheckType = y.Type, Date = y.FullChecksDate, FullCheck = y.FullCheckCounter }).Distinct();

            using (StreamWriter sw = new StreamWriter(path2))
            {
                foreach (var item in finalList)
                {
                    sw.WriteLine(($"{item.CheckType};{item.Date};{item.FullCheck}"));
                }
            }

            Console.WriteLine(@"Data is in D:\Repozytoria\FullChecks\Export\ExportFileFromSecondField.csv");
        }

        public void ExportFileFromFieldWithDate()
        {
            FullCheckImport fullCheckImport = new FullCheckImport();
            var finalList = fullCheckImport.ImportFile_Field_With_Date().GroupBy(x => new { x.Type, x.FullChecksDate }).OrderBy(s=>s.Key.Type).Select(y => new { CheckType = y.Key.Type, Date = y.Key.FullChecksDate, FullCheck = y.Max(p => p.FullCheckCounter) });
            
            using (StreamWriter sw = new StreamWriter(path3))
            {
                foreach (var item in finalList)
                {
                    sw.WriteLine(($"{item.CheckType};{item.Date};{item.FullCheck}"));
                }
            }

            Console.WriteLine(@"Data is in D:\Repozytoria\FullChecks\Export\ExportFileFromFieldWithDate.csv");
        }

    }
}