using Itmo.ObjectOrientedProgramming.Lab2.CoolingSystems;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Results;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.VideoGraphicCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPUs;

public class Cpu : ICPU
{
    public Cpu(CpuSocket socket, Number coreFrequency, VideoCore videoCore, Number capableCoreFrequency, Number tdp, Number watt, string componentName)
    {
        Socket = socket;
        CoreFrequency = coreFrequency;
        VideoCore = videoCore;
        CapableCoreFrequency = capableCoreFrequency;
        Tdp = tdp;
        Watt = watt;
        ComponentName = componentName;
    }

    public CpuSocket Socket { get; }
    public Number CoreFrequency { get; }
    public VideoCore VideoCore { get; }
    public Number CapableCoreFrequency { get; }
    public Number Tdp { get; }
    public Number Watt { get; }
    public string ComponentName { get; }

    public ICPUBuilder Direct(ICPUBuilder builder)
    {
        return builder.WithSocket(Socket)
            .WithWatt(Watt)
            .WithCoreFrequency(CoreFrequency)
            .WithVideoCore(VideoCore)
            .WithTDP(Tdp)
            .WithCapableCoreFrequency(CapableCoreFrequency);
    }

    public ResultType Validate(ICoolingSystem componentOne)
    {
        if (componentOne.Tdp.NumberValue == Tdp.NumberValue)
        {
            return new Succes();
        }

        return new InvalidBuild();
    }

    public ResultType Validate(IVideoGraphicCard componentOne)
    {
        if (VideoCore.Availability)
        {
            return new Succes();
        }

        return new InvalidBuild();
    }

    public ResultType Validate(IMotherBoard componentOne)
    {
        if (componentOne.Socket.Name == Socket.Name)
        {
            return new Succes();
        }

        return new InvalidBuild();
    }
}