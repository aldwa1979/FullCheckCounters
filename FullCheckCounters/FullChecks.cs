using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCheckCounters
{
    class FullChecks
    {
        public string Name { get; set; }
        public int FullCheckCounter { get; set; }
        public DateTime FullChecksDate { get; set; }
        public string Type { get; set; }

        public FullChecks(string name, int fullCheckCounter, DateTime fullChecksDate, string type)
        {
            Name = name;
            FullCheckCounter = fullCheckCounter;
            FullChecksDate = fullChecksDate;
            Type = type;
        }
    }
}