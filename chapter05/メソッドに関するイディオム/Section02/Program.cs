namespace Section02 {
    internal class Program {
        static void Main(string[] args) {
            Dosomething(100);
            Dosomething(100,"エラーです");
            Dosomething(100,"エラーです",5);
        }
        public static void Dosomething(int num, string message = "エラーです", int retryCount = 5) {
            Console.WriteLine($"{num} {message} {retryCount}");
        }
    }
}
