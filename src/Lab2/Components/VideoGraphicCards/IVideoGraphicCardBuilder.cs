using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.VideoGraphicCards.Attributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.VideoGraphicCards;

public interface IVideoGraphicCardBuilder
{
    IVideoGraphicCardBuilder WithHeigth(Number height);
    IVideoGraphicCardBuilder WithWidth(Number width);
    IVideoGraphicCardBuilder WithPcieVersion(PcieVersions version);
    IVideoGraphicCardBuilder WithCheapFrequency(Number frequency);
    IVideoGraphicCardBuilder WithWatt(Number watt);
    IVideoGraphicCardBuilder WithName(string componentName);
    IVideoGraphicCard Build();
}