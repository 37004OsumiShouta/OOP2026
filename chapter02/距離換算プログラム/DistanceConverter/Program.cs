

namespace DistanceConverter
{
    internal class Program{
        static void Main(string[] args)
        {
            if (int.TryParse(args[1], out var start) && int.TryParse(args[2], out var stop))
            {
                if (args.Length >= 1 && args[0] == "-tom")
                {
                    PrintFeetToMeterList(int.Parse(args[1]), int.Parse(args[2]));
                }
                else if (args.Length >= 1 && args[0] == "-tof")
                {
                    PrintMeterToFeetList(int.Parse(args[1]), int.Parse(args[2]));
                }
                else
                {
                    Console.WriteLine("引数エラー");
                }

　　　　　　　　// フィートからメートルへの対応表
                static void PrintFeetToMeterList(int start, int stop)
                {
                    for (int feet = start; feet <= stop; feet++)
                    {
                        double meter = FeetConverter.ToFeet(feet);
                        Console.WriteLine($"{feet}ft = {meter:0.0000}m");
                    }
                }


                // メートルからフィートへの対応表
                static void PrintMeterToFeetList(int start, int stop)
                {
                    for (int meter = start; meter <= stop; meter++)
                    {
                        double feet = FeetConverter.FromMeter(meter);
                        Console.WriteLine($"{meter}m = {feet:0.0000}ft");
                    }
                }

                
            }
        }

                //// フィート→メートル
                //public double ToFeet(int feet){
                //    return feet * 0.3048;
                //}

                //// メートル→フィート
                //public double FromMeter(int meter){
                //    return meter / 0.3048;
    }
}
