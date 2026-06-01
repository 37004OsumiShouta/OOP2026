using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class YearMonth {
        //5.1.1
        public int Year { get; init; }

        public int Month { get; init; }
        //5.1.2
        public bool Is21Century => 2001 <= Year && 2100 >= Year;
        //5.1.3
        public YearMonth AddOneMonth() {

        }

        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
        }
    }
}
