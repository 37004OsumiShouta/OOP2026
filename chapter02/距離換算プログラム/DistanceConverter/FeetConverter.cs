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
        public static readonly double ratio = 0.3048;    //定数

        // メートルからフィートを求める
        public static double ToFeet(int meter){
            return meter / ratio;
        }
        // フィートからメートルを求める
        public static double FromMeter(int feet){
            return feet * ratio;
        }
    }
}




