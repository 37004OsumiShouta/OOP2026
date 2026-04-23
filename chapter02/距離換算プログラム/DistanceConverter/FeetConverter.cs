using DistanceConverter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    public class FeetConverter
    {


        static void Main(string[] args)
        {
        }


        // フィート→メートル
        public static double FromMeter(int feet)
        {
            return feet * 0.3048;
        }

        // メートル→フィート
        public static double ToFeet(int meter)
        {
            return meter / 0.3048;
        }
    }
}




