using Itmo.ObjectOrientedProgramming.Lab3.Results;

namespace Itmo.ObjectOrientedProgramming.Lab3.Users;

public interface IUser
{
    void TakeMessage(Message message);
    ResultType MessageHasBeenRead(Message message);
}
