using System;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPUs;

public class CPUBuilder : ICPUBuilder
{
    private CpuSocket? _socket;
    private Number? _coreFrequency;
    private VideoCore? _videoCore;
    private Number? _capableCoreFrequency;
    private Number? _tdp;
    private Number? _watt;
    private string? _componentName;

    public ICPUBuilder WithSocket(CpuSocket socket)
    {
        _socket = socket;
        return this;
    }

    public ICPUBuilder WithCoreFrequency(Number coreFrequency)
    {
        _coreFrequency = coreFrequency;
        return this;
    }

    public ICPUBuilder WithVideoCore(VideoCore videoCore)
    {
        _videoCore = videoCore;
        return this;
    }

    public ICPUBuilder WithCapableCoreFrequency(Number capableCoreFrequency)
    {
        _capableCoreFrequency = capableCoreFrequency;
        return this;
    }

    public ICPUBuilder WithTDP(Number tdp)
    {
        _tdp = tdp;
        return this;
    }

    public ICPUBuilder WithWatt(Number watt)
    {
        _watt = watt;
        return this;
    }

    public ICPUBuilder WithName(string componentName)
    {
        _componentName = componentName;
        return this;
    }

    public ICPU Build()
    {
        return new Cpu(
            _socket ?? throw new ArgumentNullException(nameof(_socket)),
            _coreFrequency ?? throw new ArgumentNullException(nameof(_coreFrequency)),
            _videoCore ?? throw new ArgumentNullException(nameof(_videoCore)),
            _capableCoreFrequency ?? throw new ArgumentNullException(nameof(_capableCoreFrequency)),
            _tdp ?? throw new ArgumentNullException(nameof(_tdp)),
            _watt ?? throw new ArgumentNullException(nameof(_watt)),
            _componentName ?? throw new ArgumentNullException(nameof(_componentName)));
    }
}