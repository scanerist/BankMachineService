using Itmo.ObjectOrientedProgramming.Lab3.Loggings;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class Logging : IAddressee
{
    private readonly IAddressee _baseAdressee;
    private readonly ILogger _logger;

    public Logging(IAddressee baseAdressee, ILogger logger)
    {
        _baseAdressee = baseAdressee;
        _logger = logger;
    }

    public void SendMessage(Message message)
    {
        _logger.Log(message.Body);
    }
}