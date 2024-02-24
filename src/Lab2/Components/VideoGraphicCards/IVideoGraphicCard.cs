using Itmo.ObjectOrientedProgramming.Lab2.ComputerCases;
using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.Validation;
using Itmo.ObjectOrientedProgramming.Lab2.VideoGraphicCards.Attributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.VideoGraphicCards;

public interface IVideoGraphicCard : IVideoGraphicCardBuilderDirector, IComponent, IValidate<IMotherBoard>, IValidate<IComputerCase>
{
    Number Height { get; }
    Number Width { get; }
    PcieVersions Version { get; }
    Number CheapFrequency { get; }
    Number Watt { get; }
}