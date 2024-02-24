using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.CoolingSystems;

public class CoolingSystemBuilder : ICoolingSystemBuilder
{
    private Number? _sizes;
    private IReadOnlyCollection<CpuSocket>? _sockets;
    private Number? _tdp;
    private string? _componentName;
    public ICoolingSystemBuilder WithSizes(Number sizes)
    {
        _sizes = sizes;
        return this;
    }

    public ICoolingSystemBuilder WithAccesibleSockets(IReadOnlyCollection<CpuSocket> sockets)
    {
        _sockets = sockets;
        return this;
    }

    public ICoolingSystemBuilder WithTdp(Number tdp)
    {
        _tdp = tdp;
        return this;
    }

    public ICoolingSystemBuilder WithName(string componentName)
    {
        _componentName = componentName;
        return this;
    }

    public ICoolingSystem Build()
    {
        return new CoolingSystem(
            _sizes ?? throw new ArgumentNullException(nameof(_sizes)),
            _sockets ?? throw new ArgumentNullException(nameof(_sockets)),
            _tdp ?? throw new ArgumentNullException(nameof(_tdp)),
            _componentName ?? throw new ArgumentNullException(nameof(_componentName)));
    }
}