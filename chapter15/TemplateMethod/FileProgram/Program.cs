using TextFileProcessor;

string path = @"C:\Users\infosys\source\repos\OOP2026\chapter14\Section04\Section04\Program.cs";
var processor = new FileProgram();
TextProcessor.Run<FileProgram>(path);
public class FileProgram : TextProcessor {
    private string _word = " ";
    private int _count = 0;

    protected override void Initialize(string fname) {
        Console.Write("カウントしたい単語：");
        _word = Console.ReadLine()!;
        _count = 0;
        }

    protected override void Execute(string line) =>
        _count += line.Split(_word).Length - 1;


    protected override void Terminate() {
        Console.WriteLine($"{_word}は：{_count}回出現します");
    }
}