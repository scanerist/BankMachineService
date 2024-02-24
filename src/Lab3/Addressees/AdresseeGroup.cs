using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class AdresseeGroup : IAddressee
{
    private readonly IReadOnlyCollection<IAddressee> _addressees;

    public AdresseeGroup(IReadOnlyCollection<IAddressee> addressees)
    {
        _addressees = addressees;
    }

    public void SendMessage(Message message)
    {
        foreach (IAddressee addressee in _addressees)
        {
            addressee.SendMessage(message);
        }
    }
}