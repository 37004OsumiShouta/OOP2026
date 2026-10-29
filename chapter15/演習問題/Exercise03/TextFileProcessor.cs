using System.Diagnostics.Tracing;

namespace Exercise03;
internal class TextFileProcessor{
    private ITextFileService _service;

    public TextFileProcessor(ITextFileService service) {
        _service = service;
    }
    
    public void Run(string fileName) {
        _service.Initialize(fileName);
        var lines = File.ReadLines(fileName);
        foreach (var line in lines) {
            if (_service.Execute(line) == false)
                break;
        }
        _service.Terminate();
    }
}
