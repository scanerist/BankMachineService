using System;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.HDDs;

public class HDDBuilder : IHDDBuilder
{
    private Number? _capacity;
    private Number? _rotationSpeedOfQUil;
    private Number? _watt;
    private string? _componentName;
    public IHDDBuilder WithCapacity(Number capacity)
    {
        _capacity = capacity;
        return this;
    }

    public IHDDBuilder WithRotationSpeedOfQuil(Number rotationSpeedOfQUil)
    {
        _rotationSpeedOfQUil = rotationSpeedOfQUil;
        return this;
    }

    public IHDDBuilder WithWatt(Number watt)
    {
        _watt = watt;
        return this;
    }

    public IHDDBuilder WithName(string componentName)
    {
        _componentName = componentName;
        return this;
    }

    public IHDD Build()
    {
        return new HDD(
            _capacity ?? throw new ArgumentNullException(nameof(_capacity)),
            _rotationSpeedOfQUil ?? throw new ArgumentNullException(nameof(_rotationSpeedOfQUil)),
            _watt ?? throw new ArgumentNullException(nameof(_watt)),
            _componentName ?? throw new ArgumentNullException(nameof(_componentName)));
    }
}