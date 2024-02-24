using Itmo.ObjectOrientedProgramming.Lab2.RAMs.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAMs;

public interface IRAMBuilder
{
    IRAMBuilder WithAvailableStorage(Number storage);
    IRAMBuilder WithPairs(SupportedFrequencyBetweenJedecAndWoltage pairs);
    IRAMBuilder WithFormFactor(RAMFromFactor fromFactor);
    IRAMBuilder WithDdrVersion(Number ddrVersion);
    IRAMBuilder WithWatt(Number watt);
    IRAMBuilder WithName(string componentName);
}