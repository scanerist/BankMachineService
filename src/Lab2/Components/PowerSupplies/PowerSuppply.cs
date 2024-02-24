using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerSupplies;

public class PowerSuppply : IPowerSupply
{
    public PowerSuppply(Number peakLoad, string componentName)
    {
        PeakLoad = peakLoad;
        ComponentName = componentName;
    }

    public Number PeakLoad { get; }
    public string ComponentName { get; }
    public IPowerSupplyBuilder Direct(IPowerSupplyBuilder builder)
    {
        return builder.WithPeakLoad(PeakLoad);
    }
}