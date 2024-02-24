using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab3.Loggings;

public class FileLogger : ILogger
{
    private readonly string _filePath;
    private readonly StreamWriter _streamWriter;

    public FileLogger(string filePath)
    {
        _filePath = filePath;
        var file = new FileInfo(_filePath);
        _streamWriter = file.CreateText();
    }

    public void Log(string message)
    {
        _streamWriter.WriteLine(message);
    }
}