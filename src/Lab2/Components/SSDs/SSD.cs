using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.SSDs;

public class SSD : ISSD
{
    public SSD(ConnectionVariant variant, Number capacity, Number maxWorkSpeed, Number watt, string componentName)
    {
        Variant = variant;
        Capacity = capacity;
        MaxWorkSpeed = maxWorkSpeed;
        Watt = watt;
        ComponentName = componentName;
    }

    public ConnectionVariant Variant { get; }
    public Number Capacity { get; }
    public Number MaxWorkSpeed { get; }
    public Number Watt { get; }
    public string ComponentName { get; }
    public ISSDBuilder Direct(ISSDBuilder build)
    {
        throw new System.NotImplementedException();
    }
}