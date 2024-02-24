using Itmo.ObjectOrientedProgramming.Lab3.Messengers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Mock;

public class MessengerMock : IMessenger
{
    public int Count { get; private set; }
    public void PrintMessage(string message)
    {
        Count++;
    }
}