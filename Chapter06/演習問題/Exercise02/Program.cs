namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("整数文字列：");
            if (int.TryParse(Console.ReadLine(), out var number)) {
                var num = number.ToString("#,0");
                Console.WriteLine(num);
            } else {
                Console.WriteLine("変換できません");
            }
        }
    }
}
