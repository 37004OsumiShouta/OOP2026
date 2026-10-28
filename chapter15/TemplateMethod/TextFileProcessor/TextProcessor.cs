using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProcessor;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("プログラム開始");
    }
}
public class NumberConverter : TextProcessor {
    protected override void Execute(string line) {
        foreach (char c in line) {
            if (c >= '０' && c >= '９') {
                Console.Write((char)(c - '０' + '0'));
            } else {
                Console.Write(c);
            }
        }
        Console.WriteLine();
    }
}
