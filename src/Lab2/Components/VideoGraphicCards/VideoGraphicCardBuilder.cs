using System;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.VideoGraphicCards.Attributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.VideoGraphicCards;

public class VideoGraphicCardBuilder : IVideoGraphicCardBuilder
{
    private Number? _height;
    private Number? _width;
    private PcieVersions? _version;
    private Number? _cheapFrequency;
    private Number? _watt;
    private string? _componentName;

    public IVideoGraphicCardBuilder WithHeigth(Number height)
    {
        _height = height;
        return this;
    }

    public IVideoGraphicCardBuilder WithWidth(Number width)
    {
        _width = width;
        return this;
    }

    public IVideoGraphicCardBuilder WithPcieVersion(PcieVersions version)
    {
        _version = version;
        return this;
    }

    public IVideoGraphicCardBuilder WithCheapFrequency(Number frequency)
    {
        _cheapFrequency = frequency;
        return this;
    }

    public IVideoGraphicCardBuilder WithWatt(Number watt)
    {
        _watt = watt;
        return this;
    }

    public IVideoGraphicCardBuilder WithName(string componentName)
    {
        _componentName = componentName;
        return this;
    }

    public IVideoGraphicCard Build()
    {
        return new VideoGraphicCard(
            _height ?? throw new ArgumentNullException(nameof(_height)),
            _width ?? throw new ArgumentNullException(nameof(_width)),
            _version ?? throw new ArgumentNullException(nameof(_version)),
            _cheapFrequency ?? throw new ArgumentNullException(nameof(_cheapFrequency)),
            _watt ?? throw new ArgumentNullException(nameof(_watt)),
            _componentName ?? throw new ArgumentNullException(nameof(_componentName)));
    }
}