using Itmo.ObjectOrientedProgramming.Lab3.Messengers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class AdresseeMessenger : IAddressee
{
    private readonly IMessenger _messenger;

    public AdresseeMessenger(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void SendMessage(Message message)
    {
        _messenger.PrintMessage(message.Body);
    }
}