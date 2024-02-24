using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.XMPs;

public class XMP : IXmp
{
    public XMP(Number timing, Number voltage, Number frequency, string componentName)
    {
        Timing = timing;
        Voltage = voltage;
        Frequency = frequency;
        ComponentName = componentName;
    }

    public Number Timing { get; }
    public Number Voltage { get; }
    public Number Frequency { get; }
    public string ComponentName { get; }
    public IXmpBuilder Direct(IXmpBuilder builder)
    {
        throw new System.NotImplementedException();
    }
}