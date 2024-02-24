using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.RAMs.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab2.RAMs;

public interface IRAM : IRAMBuilderDirector, IComponent, IValidate<IMotherBoard>
{
    Number AvailableStorage { get; }
    SupportedFrequencyBetweenJedecAndWoltage Pairs { get; }
    RAMFromFactor FromFactor { get;  }
    Number DdrVersion { get; }
    Number Watt { get; }
}