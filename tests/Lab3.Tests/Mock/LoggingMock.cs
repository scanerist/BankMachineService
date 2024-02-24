using Itmo.ObjectOrientedProgramming.Lab3.Loggings;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Mock;

public class LoggingMock : ILogger
{
    public int LoggingCount { get; private set; }

    public void Log(string message)
    {
        LoggingCount++;
    }
}