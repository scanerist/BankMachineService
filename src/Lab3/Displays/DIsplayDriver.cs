using System;
using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class DisplayDriver : IDisplayDriver
{
    private readonly Color _color;

    public DisplayDriver(Color color)
    {
        _color = color;
    }

    public void Print(string message)
    {
        Console.WriteLine(message);
    }

    public string UpdateColor(string message)
    {
        return Crayon.Output.Rgb(_color.R, _color.G, _color.B).Text(message);
    }

    public void Clear()
    {
        Console.Clear();
    }
}