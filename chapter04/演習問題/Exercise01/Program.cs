
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
               "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
            Console.WriteLine("---");
        }

        private static void Exercise1(List<string> langs) {
            //foreach文
            Console.WriteLine("foreach文で出力");
            var exists = langs.Where(s => s.Contains("S"));
            foreach (var s in exists)
                Console.WriteLine(s);

            Console.WriteLine();//改行
            //for文
            Console.WriteLine("\nfor文で出力");
            for (int i = 0; i < langs.Count; i++) {
                if (langs[i].Contains("S")) {
                    Console.WriteLine(langs[i]);
                }
            }
            Console.WriteLine("\nwhile文で出力");
            int j = 0;
            while(j < langs.Count) {
                if (langs[j].Contains("S")) {
                    Console.WriteLine(langs[j]);
                }
                j++;
            }
        }

        private static void Exercise2(List<string> langs) {

        }

        private static void Exercise3(List<string> langs) {

        }
    }
}
