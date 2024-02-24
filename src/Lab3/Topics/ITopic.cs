using Itmo.ObjectOrientedProgramming.Lab3.Addressees;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topics;

public interface ITopic
{
    string TopicName { get; }
    IAddressee AdresseeName { get; }
    void SendMessage(Message message);
}