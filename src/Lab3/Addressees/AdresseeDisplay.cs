using Itmo.ObjectOrientedProgramming.Lab3.Display;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class AdresseeDisplay : IAddressee
{
    private readonly IDisplay _display;

    public AdresseeDisplay(IDisplay display)
    {
        _display = display;
    }

    public void SendMessage(Message message)
    {
        _display.Print(message.Body);
    }
}