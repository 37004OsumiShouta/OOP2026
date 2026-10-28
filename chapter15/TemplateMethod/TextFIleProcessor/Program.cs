using System.Diagnostics.Tracing;

namespace TextFileProcessor;

public abstract class TextProcessor {
    public static void Run<T>(string fileName) where T : TextProcessor, new() {
        var self = new T();
        self.Process(fileName);
        TextProcessor.Run<NumberConverter>(@"C:\Users\infosys\source\repos\OOP2026\chapter14\Section04\Section04\Program.cs");
    }

    private void Process(string fileName) {
        Initialize(fileName);
        var lines = File.ReadLines(fileName);
        foreach (var line in lines) {
            Execute(line);
        }
        Terminate();
    }

    protected virtual void Initialize(string fname) { }
    protected virtual void Execute(string line) { }
    protected virtual void Terminate() { }

    }