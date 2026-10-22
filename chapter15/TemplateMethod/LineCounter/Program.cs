using TextFileProcessor;

string path = @"\\172.16.42.1\学生\2026_情報システム\オブジェクト指向プログラミングⅠ\吾輩は猫である.txt";
TextProcessor.Run<LineCounterProcessor>(path);



public class LineCounterProcessor : TextProcessor {

    private int _count = 0;

    protected override void Initialize(string fname) =>
        _count = 0;

    protected override void Execute(string line) =>
        _count++;

    protected override void Terminate() =>
        Console.WriteLine("{0} 行", _count);
    }