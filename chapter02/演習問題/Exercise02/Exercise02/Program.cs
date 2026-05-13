namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            PrintMeterToInchList(1, 10); 
        }
                static void PrintMeterToInchList(int start ,int stop ) {
                    for (int inch = start; inch <= stop; inch++) {
                        double meter = ToMeter(inch);
                        Console.WriteLine($"{inch}inch = {meter:0.0000}m");
                    }
                }
           
        private static double ToMeter(double inch) {
            return inch * 0.0254;
        }
    }
}
