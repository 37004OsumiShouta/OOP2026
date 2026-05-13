namespace Convarter {
    internal class Program {
        static void Main(string[] args) {
        }
        public class InchConverter {
            public static readonly double ratio = 0.0254;    //定数
                                                             // メートルからフィートを求める
            public static double Toinch(int meter) {
                return meter / ratio;
            }
            // フィートからメートルを求める
            public static double FromMeter(int inch) {
                return inch * ratio;
            }
        }
    }
}
