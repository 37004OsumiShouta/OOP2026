
using System.ComponentModel.Design;

namespace Exercise01 {
    internal class Program {

        static void Main(string[] args) {
            List<string> langs = [
               "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];
            Console.WriteLine("--4-1-1--");
            Exercise1(langs);
            Console.WriteLine("--4-1-2--");
            Exercise2(langs);
            
            Exercise3(langs);
            Console.WriteLine("---");
        }

        private static void Exercise1(List<string> langs) {
            //foreach文
            Console.WriteLine("foreach文で出力");
            foreach (var s in langs) {
                if(s.Contains("S"))
                Console.WriteLine(s);
            }
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
            while (j < langs.Count) {
                if (langs[j].Contains("S"))
                    Console.WriteLine(langs[j]);
                j++;
            }
        }

        private static void Exercise2(List<string> langs) {
            var selected = langs.Where(s => s.Contains("S"));
            foreach (var lang in selected) {
                Console.WriteLine(lang);
            }
        }

        private static void Exercise3(List<string> langs) {
            Console.WriteLine("\n---4-1-3---");
            var name = langs.Find(s => s.Length == 10);
           
            var message = GetMessage(name) ?? "unknown";
            Console.WriteLine(message);

            message = null;
            message ??= "null";
        }

        private static object? DefaultMessage() {
            return DefaultMessage;
        }

        private static object? GetMessage(string code) {
            return code;
        }
    }
}
