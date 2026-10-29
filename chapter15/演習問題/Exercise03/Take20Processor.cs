using System;

namespace Exercise03;

public class Take20Processor : TextProcessor {
    private int _count = 0;

    protected override void Execute(string line) {
        if (_count < 20) {
            Console.WriteLine(line);
            _count++;
        }
    }
}