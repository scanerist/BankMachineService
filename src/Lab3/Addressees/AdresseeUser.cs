using Itmo.ObjectOrientedProgramming.Lab3.Users;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class AdresseeUser : IAddressee
{
    private readonly IUser _user;

    public AdresseeUser(IUser user)
    {
        _user = user;
    }

    public void SendMessage(Message message)
    {
        _user.TakeMessage(message);
    }
}