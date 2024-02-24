using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class Number
{
    private int _numberValue;

    public int NumberValue
    {
        get => _numberValue;

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("the number must be positive!.", nameof(value));
            }

            _numberValue = value;
        }
    }
}
