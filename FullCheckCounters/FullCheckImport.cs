using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCheckCounters
{
    class FullCheckImport
    {
        string s;
        int x = 0;
        int grecosID = 0;
        string name;

        List<FullChecks> fullCheck_From_Second_Field = new List<FullChecks>();
        List<FullChecks> fullCheck_From_Field_With_Date = new List<FullChecks>();

        public List<FullChecks> ImportFile_Second_Field()
        {
            String[] separator = { " [", "]", ". ", "<td>", "</td>", "<b>", "</b>", " | ", "<br />" };
            ListOfFiles listOfFiles = new ListOfFiles();
            var listOfFilesToImport = listOfFiles.Files();

            foreach (var path in listOfFilesToImport)
            {
                x = 0;
                grecosID = 0;

                if (File.Exists(path.FullName))
                {
                    using (StreamReader sr = File.OpenText(path.FullName))
                    {
                        while ((s = sr.ReadLine()) != null)
                        {
                            x++;
                            
                            //Searching of Grecos.pl section

                            if (s.Contains("Grecos.pl"))
                            {
                                grecosID = x;
                            }

                            //Adding first Type and checks
                            try
                            {
                                if (x == grecosID + 3 && grecosID != 0)
                                {
                                    var name1 = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
                                    name = name1[0];
                                }

                                if (x == grecosID + 11 && grecosID != 0)
                                {
                                    var y = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                                    fullCheck_From_Second_Field.Add(new FullChecks(path.Name, Int32.Parse(y[1]), DateTime.Parse(DateTime.ParseExact(path.Name.Substring(0, 8), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd")), name));
                                }
                            }

                            catch(Exception ex)
                            {
                                Console.WriteLine("brak bloku");
                            }

                            //Adding second Type and checks
                            try
                            {
                                if (x == grecosID + 20 && grecosID != 0)
                                {
                                    var name1 = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
                                    name = name1[0];
                                }

                                if (x == grecosID + 28 && grecosID != 0)
                                {
                                    var y = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                                    fullCheck_From_Second_Field.Add(new FullChecks(path.Name, Int32.Parse(y[1]), DateTime.Parse(DateTime.ParseExact(path.Name.Substring(0, 8), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd")), name));
                                }
                            }

                            catch (Exception ex)
                            {
                                Console.WriteLine("brak bloku");
                            }
                            
                            //Adding third Type and checks
                            try
                            {
                                if (x == grecosID + 37 && grecosID != 0)
                                {
                                    var name1 = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
                                    name = name1[0];
                                }

                                if (x == grecosID + 45 && grecosID != 0)
                                {
                                    var y = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                                    fullCheck_From_Second_Field.Add(new FullChecks(path.Name, Int32.Parse(y[1]), DateTime.Parse(DateTime.ParseExact(path.Name.Substring(0, 8), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd")), name));
                                }
                            }

                            catch (Exception ex)
                            {
                                Console.WriteLine("brak bloku");
                            }

                            //Adding fourth Type and checks
                            try
                            {
                                if (x == grecosID + 54 && grecosID != 0)
                                {
                                    var name1 = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
                                    name = name1[0];
                                }

                                if (x == grecosID + 62 && grecosID != 0)
                                {
                                    var y = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                                    fullCheck_From_Second_Field.Add(new FullChecks(path.Name, Int32.Parse(y[1]), DateTime.Parse(DateTime.ParseExact(path.Name.Substring(0, 8), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd")), name));
                                }
                            }

                            catch (Exception ex)
                            {
                                Console.WriteLine("brak bloku");
                            }

                            //Adding fifth Type and checks
                            try
                            {
                                if (x == grecosID + 71 && grecosID != 0)
                                {
                                    var name1 = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
                                    name = name1[0];
                                }

                                if (x == grecosID + 79 && grecosID != 0)
                                {
                                    var y = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                                    fullCheck_From_Second_Field.Add(new FullChecks(path.Name, Int32.Parse(y[1]), DateTime.Parse(DateTime.ParseExact(path.Name.Substring(0, 8), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd")), name));
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("brak bloku");
                            }
                        }
                    }
                }
            }

            return fullCheck_From_Second_Field;
        }

        public List<FullChecks> ImportFile_Field_With_Date()
        {
            String[] separator = { "</button>", " [", "]", ". ", "<td>", "</td>", "<b>", "</b>" };
            ListOfFiles listOfFiles = new ListOfFiles();
            var listOfFilesToImport = listOfFiles.Files();

            foreach (var path in listOfFilesToImport)
            {
                x = 0;
                grecosID = 0;

                if (File.Exists(path.FullName))
                {
                    using (StreamReader sr = File.OpenText(path.FullName))
                    {
                        while ((s = sr.ReadLine()) != null)
                        {
                            x++;

                            //Searching of Grecos.pl section

                            if (s.Contains("Grecos.pl"))
                            {
                                grecosID = x;
                            }

                            //Adding first Type and checks
                            try
                            {
                                if (x == grecosID + 3 && grecosID != 0)
                                {
                                    var name1 = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
                                    name = name1[0];
                                }

                                if (x == grecosID + 11 && grecosID != 0)
                                {
                                    var y = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                                    fullCheck_From_Field_With_Date.Add(new FullChecks(path.Name, Int32.Parse(y[1]), DateTime.Parse(y[2]), name));
                                }
                            }

                            catch (Exception ex)
                            {
                                Console.WriteLine("brak bloku");
                            }

                            //Adding second Type and checks
                            try
                            {
                                if (x == grecosID + 20 && grecosID != 0)
                                {
                                    var name1 = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
                                    name = name1[0];
                                }

                                if (x == grecosID + 28 && grecosID != 0)
                                {
                                    var y = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                                    fullCheck_From_Field_With_Date.Add(new FullChecks(path.Name, Int32.Parse(y[1]), DateTime.Parse(y[2]), name));
                                }
                            }

                            catch (Exception ex)
                            {
                                Console.WriteLine("brak bloku");
                            }

                            //Adding third Type and checks
                            try
                            {
                                if (x == grecosID + 37 && grecosID != 0)
                                {
                                    var name1 = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
                                    name = name1[0];
                                }

                                if (x == grecosID + 45 && grecosID != 0)
                                {
                                    var y = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                                    fullCheck_From_Field_With_Date.Add(new FullChecks(path.Name, Int32.Parse(y[1]), DateTime.Parse(y[2]), name));
                                }
                            }

                            catch (Exception ex)
                            {
                                Console.WriteLine("brak bloku");
                            }

                            //Adding fourth Type and checks
                            try
                            {
                                if (x == grecosID + 54 && grecosID != 0)
                                {
                                    var name1 = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
                                    name = name1[0];
                                }

                                if (x == grecosID + 62 && grecosID != 0)
                                {
                                    var y = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                                    fullCheck_From_Field_With_Date.Add(new FullChecks(path.Name, Int32.Parse(y[1]), DateTime.Parse(y[2]), name));
                                }
                            }

                            catch (Exception ex)
                            {
                                Console.WriteLine("brak bloku");
                            }

                            //Adding fifth Type and checks
                            try
                            {
                                if (x == grecosID + 71 && grecosID != 0)
                                {
                                    var name1 = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
                                    name = name1[0];
                                }

                                if (x == grecosID + 79 && grecosID != 0)
                                {
                                    var y = s.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                                    fullCheck_From_Field_With_Date.Add(new FullChecks(path.Name, Int32.Parse(y[1]), DateTime.Parse(y[2]), name));
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("brak bloku");
                            }
                        }
                    }
                }
            }

            return fullCheck_From_Field_With_Date;
        }
    }
}