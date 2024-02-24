using Itmo.ObjectOrientedProgramming.Lab2.ComputerCases;
using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Results;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.VideoGraphicCards.Attributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.VideoGraphicCards;

public class VideoGraphicCard : IVideoGraphicCard
{
    public VideoGraphicCard(Number height, Number width, PcieVersions version, Number cheapFrequency, Number watt, string componentName)
    {
        Height = height;
        Width = width;
        Version = version;
        CheapFrequency = cheapFrequency;
        Watt = watt;
        ComponentName = componentName;
    }

    public Number Height { get; }
    public Number Width { get; }
    public PcieVersions Version { get; }
    public Number CheapFrequency { get; }
    public Number Watt { get; }
    public string ComponentName { get; }

    public IVideoGraphicCardBuilder Direct(IVideoGraphicCardBuilder builder)
    {
        return builder.WithHeigth(Height)
            .WithWidth(Width)
            .WithWatt(Watt)
            .WithCheapFrequency(CheapFrequency)
            .WithPcieVersion(Version);
    }

    public ResultType Validate(IMotherBoard componentOne)
    {
        if (componentOne.PciELines.Name == Version.Version)
        {
            return new Succes();
        }

        return new InvalidBuild();
    }

    public ResultType Validate(IComputerCase componentOne)
    {
        if (componentOne.Length == Height && componentOne.Width == Width)
        {
            return new Succes();
        }

        return new InvalidBuild();
    }
}