
using System.ComponentModel;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smaet squid who asks for job pen";
            Exercise01(text);
            Console.WriteLine();
            Exercise02(text);
        }

        private static void Exercise01(string text) {
            var array = new Dictionary<char, int>();
            foreach (char ch in text.ToUpper()) {
                if ('A' <= ch && ch <= 'Z') {
                    if (array.ContainsKey(ch)) {
                        array[ch]++;
                    } else {
                        array[ch] = 1;
                    }
                }
            }
            foreach (var a in array.OrderBy(x => x.Key))
                Console.WriteLine($"{a.Key}:{a.Value}");
        }

        private static void Exercise02(string text) {
            var array = new SortedDictionary<char, int>();
            foreach (char ch in text.ToUpper()) {
                if ('A' <= ch && ch <= 'Z') {
                    if (array.ContainsKey(ch)) {
                        array[ch]++;
                    } else {
                        array[ch] = 1;
                    }
                }
            }
            foreach (var a in array)
                Console.WriteLine($"{a.Key}:{a.Value}");
        }
    }
    }
