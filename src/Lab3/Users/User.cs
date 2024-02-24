using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Users;

public class User : IUser
{
    private readonly IDictionary<Message, bool> _takenMessage;
    public User()
    {
        _takenMessage = new Dictionary<Message, bool>();
    }

    public void TakeMessage(Message message)
    {
        _takenMessage.Add(message, false);
    }

    public ResultType MessageHasBeenRead(Message message)
    {
        if (!_takenMessage.ContainsKey(message))
        {
            return new MessageNotFound();
        }

        if (_takenMessage[message])
        {
            return new AlreadyRead();
        }

        _takenMessage[message] = true;

        return new WasRead();
    }
}