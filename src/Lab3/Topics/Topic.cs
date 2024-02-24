using Itmo.ObjectOrientedProgramming.Lab3.Addressees;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topics;

public class Topic : ITopic
{
    public Topic(string topicName, IAddressee addresseeName)
    {
        TopicName = topicName;
        AdresseeName = addresseeName;
    }

    public string TopicName { get; }
    public IAddressee AdresseeName { get; }
    public void SendMessage(Message message)
    {
        AdresseeName.SendMessage(message);
    }
}