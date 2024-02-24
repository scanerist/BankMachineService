using Itmo.ObjectOrientedProgramming.Lab3.Addressees;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.Mock;

public class FilteringMock : IAddressee
{
    public int FilteringCount { get; private set; }
    public void SendMessage(Message message)
    {
        FilteringCount++;
    }
}