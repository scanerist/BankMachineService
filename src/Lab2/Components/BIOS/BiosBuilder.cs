using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.BIOS.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs;

namespace Itmo.ObjectOrientedProgramming.Lab2.BIOS;

public class BiosBuilder : IBiosBuilder
{
    private BiosType? _biosType;
    private BiosVersion? _biosVersion;
    private IReadOnlyCollection<ICPU>? _cpus;
    private string? _componentName;

    public IBiosBuilder WithType(BiosType type)
    {
        _biosType = type;
        return this;
    }

    public IBiosBuilder WithVersion(BiosVersion biosVersion)
    {
        _biosVersion = biosVersion;
        return this;
    }

    public IBiosBuilder WithAccesibleCpus(IReadOnlyCollection<ICPU> processors)
    {
        _cpus = processors;
        return this;
    }

    public IBiosBuilder WithName(string componentName)
    {
        _componentName = componentName;
        return this;
    }

    public IBios Build()
    {
        return new BIOS(
            _biosType ?? throw new ArgumentException(nameof(_biosType)),
            _biosVersion ?? throw new ArgumentException(nameof(_biosVersion)),
            _cpus ?? throw new ArgumentException(nameof(_cpus)),
            _componentName ?? throw new ArgumentNullException(nameof(_componentName)));
    }
}