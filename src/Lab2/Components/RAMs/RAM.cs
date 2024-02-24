using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.RAMs.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.Results;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAMs;

public class RAM : IRAM
{
    public RAM(Number availableStorage, SupportedFrequencyBetweenJedecAndWoltage pairs, RAMFromFactor fromFactor, Number ddrVersion, Number watt, string componentName)
    {
        AvailableStorage = availableStorage;
        Pairs = pairs;
        FromFactor = fromFactor;
        DdrVersion = ddrVersion;
        Watt = watt;
        ComponentName = componentName;
    }

    public Number AvailableStorage { get; }
    public SupportedFrequencyBetweenJedecAndWoltage Pairs { get; }
    public RAMFromFactor FromFactor { get; }
    public Number DdrVersion { get; }
    public Number Watt { get; }
    public string ComponentName { get; }
    public IRAMBuilder Direct(IRAMBuilder builder)
    {
        return builder.WithAvailableStorage(AvailableStorage)
            .WithPairs(Pairs)
            .WithFormFactor(FromFactor)
            .WithDdrVersion(DdrVersion)
            .WithWatt(Watt);
    }

    public ResultType Validate(IMotherBoard componentOne)
    {
        if (componentOne.FormFactor.Name == FromFactor.Name)
        {
            return new Succes();
        }

        if (componentOne.Ddr == DdrVersion)
        {
            return new Succes();
        }

        return new InvalidBuild();
    }
}