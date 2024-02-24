using System;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerSupplies;

public class PowerSupplyBuilder : IPowerSupplyBuilder
{
    private Number? _peakLoad;
    private string? _componentName;
    public IPowerSupplyBuilder WithPeakLoad(Number peakLoad)
    {
        _peakLoad = peakLoad;
        return this;
    }

    public IPowerSupplyBuilder WithName(string componentName)
    {
        _componentName = componentName;
        return this;
    }

    public IPowerSupply Build()
    {
        return new PowerSuppply(
            _peakLoad ?? throw new ArgumentNullException(nameof(_peakLoad)),
            _componentName ?? throw new ArgumentNullException(nameof(_componentName)));
    }
}