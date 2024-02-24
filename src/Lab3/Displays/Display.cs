using Itmo.ObjectOrientedProgramming.Lab3.Display;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class Display : IDisplay
{
    private readonly IDisplayDriver _displayDriver;

    public Display(DisplayDriver displayDriver)
    {
        _displayDriver = displayDriver;
    }

    public void Print(string message)
    {
        _displayDriver.Clear();
        _displayDriver.UpdateColor(message);
        _displayDriver.Print(message);
    }
}