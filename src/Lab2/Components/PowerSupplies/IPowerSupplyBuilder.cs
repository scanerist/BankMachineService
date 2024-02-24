using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerSupplies;

public interface IPowerSupplyBuilder
{
    IPowerSupplyBuilder WithPeakLoad(Number peakLoad);
    IPowerSupplyBuilder WithName(string componentName);
    IPowerSupply Build();
}