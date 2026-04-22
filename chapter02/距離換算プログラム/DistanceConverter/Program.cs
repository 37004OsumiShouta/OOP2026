

namespace DistanceConverter
{
    internal class Program
    {
        static void Main(string[] args){
            if (args.Length >= 1 && args[0] == "-tom"){
                PrintFeetToMeterList(10, 30);
            }else if (args.Length >= 1 && args[0] == "-tom"){
                PrintFeetToMeterList(5, 15);
            }else{
              Console.WriteLine("引数エラー");
                //メートルからフィートへの対応表
                for (int meter = 1; meter <= 10; meter++){
                    double feet = MeterToFeet(meter);
                    Console.WriteLine($"{meter}m = {feet:0.0000}ft");
                }
            //フィートからメートルへの対応表
        static void PrintFeetToMeterList(int start, double stop){
            for (int feet = 1; feet <= 10; feet++){
                double meter = FeetToMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.0000}m");
            }
        }
        //フィートからメートルを求める
        static double FeetToMeter(int feet){
            return feet * 0.3048;//feet : 0.3048
        }
        //メートルからフィートを求める
        static double MeterToFeet(int meter){
            return meter / 0.3048;
        }
    }
}

        private static void PrintFeetToMeterList(int start, int stop){
            for (int meter = start; meter <= stop; meter++) {
                double feet = MeterToFeet(meter);
                Console.WriteLine($"{meter}m = {feet:0.0000}ft");
            }
        }

        private static double MeterToFeet(int meter)
        {
            throw new NotImplementedException();
        }
    }
}
