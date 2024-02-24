namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class AdresseeProxy : IAddressee
{
    private readonly Priority _sentMessagePriority;
    private readonly IAddressee _concreteAddressee;

    public AdresseeProxy(int sentMessagePriority, IAddressee concreteAddressee)
    {
        _concreteAddressee = concreteAddressee;
        _sentMessagePriority = new Priority(sentMessagePriority);
    }

    public void SendMessage(Message message)
    {
        if (message.MessagePriority.Value > _sentMessagePriority.Value)
        {
            _concreteAddressee.SendMessage(message);
        }
    }
}
