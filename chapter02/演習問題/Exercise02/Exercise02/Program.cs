namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            if (int.TryParse(args[1], out var start) && int.TryParse(args[2], out var stop)) {
                if (args.Length >= 1 && args[0] == "-tom") {
                    PrintInchToMeterList(int.Parse(args[1]), int.Parse(args[2]));
                } else if (args.Length >= 1 && args[0] == "-tof") {
                    PrintMeterToInchList(int.Parse(args[1]), int.Parse(args[2]));
                } else {
                    Console.WriteLine("引数エラー");
                }

                static void PrintInchToMeterList(int start, int stop) {
                    for (int inch = start; inch <= stop; inch++) {
                        double meter = InchConverter.ToFeet(inch);
                        Console.WriteLine($"{inch}ft = {meter:0.0000}m");
                    }
                }
                static void PrintMeterToInchList(int start, int stop) {
                    for (int meter = start; meter <= stop; meter++) {
                        double inch = InchConverter.FromMeter(meter);
                        Console.WriteLine($"{meter}m = {inch:0.0000}ft");
                    }
                }
            }
        }
        public double ToFeet(int inch) {
            return inch * 0.3048;
        }
    }
}
