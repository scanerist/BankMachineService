using Itmo.ObjectOrientedProgramming.Lab2.RAMs.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAMs;

public class RAMBuilder : IRAMBuilder
{
    private Number? _availableStorage;
    private SupportedFrequencyBetweenJedecAndWoltage? _pairs;
    private RAMFromFactor? _ramFromFactor;
    private Number? _ddrVersion;
    private Number? _watt;
    private string? _componentName;
    public IRAMBuilder WithAvailableStorage(Number storage)
    {
        _availableStorage = storage;
        return this;
    }

    public IRAMBuilder WithPairs(SupportedFrequencyBetweenJedecAndWoltage pairs)
    {
        _pairs = pairs;
        return this;
    }

    public IRAMBuilder WithFormFactor(RAMFromFactor fromFactor)
    {
        _ramFromFactor = fromFactor;
        return this;
    }

    public IRAMBuilder WithDdrVersion(Number ddrVersion)
    {
        _ddrVersion = ddrVersion;
        return this;
    }

    public IRAMBuilder WithWatt(Number watt)
    {
        _watt = watt;
        return this;
    }

    public IRAMBuilder WithName(string componentName)
    {
        _componentName = componentName;
        return this;
    }
}