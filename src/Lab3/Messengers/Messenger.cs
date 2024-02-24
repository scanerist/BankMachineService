using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messengers;

public class Messenger : IMessenger
{
    public void PrintMessage(string message)
    {
        Console.WriteLine("Message");
        Console.WriteLine(message);
    }
}