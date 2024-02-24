using System;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.SSDs;

public class SSDBuilder : ISSDBuilder
{
    private ConnectionVariant? _variant;
    private Number? _capacity;
    private Number? _maxWorkSpeed;
    private Number? _watt;
    private string? _componentName;

    public ISSDBuilder WithConnectionVAriant(ConnectionVariant variant)
    {
        _variant = variant;
        return this;
    }

    public ISSDBuilder WithCapacity(Number capacity)
    {
        _capacity = capacity;
        return this;
    }

    public ISSDBuilder WithMaxWorkSpeed(Number maxWorkSpeed)
    {
        _maxWorkSpeed = maxWorkSpeed;
        return this;
    }

    public ISSDBuilder WithWatt(Number watt)
    {
        _watt = watt;
        return this;
    }

    public ISSDBuilder BuilderWithName(string componentName)
    {
        _componentName = componentName;
        return this;
    }

    public ISSD Build()
    {
        return new SSD(
            _variant ?? throw new ArgumentNullException(nameof(_variant)),
            _capacity ?? throw new ArgumentNullException(nameof(_capacity)),
            _maxWorkSpeed ?? throw new ArgumentNullException(nameof(_maxWorkSpeed)),
            _watt ?? throw new ArgumentNullException(nameof(_watt)),
            _componentName ?? throw new ArgumentNullException(nameof(_componentName)));
    }
}