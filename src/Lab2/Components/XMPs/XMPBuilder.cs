using System;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.XMPs;

public class XMPBuilder : IXmpBuilder
{
    private Number? _timing;
    private Number? _voltage;
    private Number? _frequency;
    private string? _componentName;

    public IXmpBuilder Withtiming(Number timing)
    {
        _timing = timing;
        return this;
    }

    public IXmpBuilder WithVoltage(Number volatge)
    {
        _voltage = volatge;
        return this;
    }

    public IXmpBuilder WithFrequency(Number frequency)
    {
        _frequency = frequency;
        return this;
    }

    public IXmpBuilder WithName(string compponentName)
    {
        _componentName = compponentName;
        return this;
    }

    public IXmp Build()
    {
        return new XMP(
            _timing ?? throw new ArgumentNullException(nameof(_timing)),
            _voltage ?? throw new ArgumentNullException(nameof(_voltage)),
            _frequency ?? throw new ArgumentNullException(nameof(_frequency)),
            _componentName ?? throw new ArgumentNullException(nameof(_componentName)));
    }
}