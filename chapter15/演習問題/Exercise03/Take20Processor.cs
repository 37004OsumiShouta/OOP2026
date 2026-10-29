using System;

namespace Exercise03;

public class Take20Processor : ITextFileService {
    private int _count = 0;

    public void Initialize(string fileName) {

    }

    public bool Execute(string line) {
        if (_count < 20) {
            Console.WriteLine(line);
            
        }
        _count++;
        return _count < 20;
    }
    public void Terminate() {

    }
}