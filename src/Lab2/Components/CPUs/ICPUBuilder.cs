using Itmo.ObjectOrientedProgramming.Lab2.CPUs.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPUs;

public interface ICPUBuilder
{
    ICPUBuilder WithSocket(CpuSocket socket);
    ICPUBuilder WithCoreFrequency(Number coreFrequency);
    ICPUBuilder WithVideoCore(VideoCore videoCore);
    ICPUBuilder WithCapableCoreFrequency(Number capableCoreFrequency);
    ICPUBuilder WithTDP(Number tdp);
    ICPUBuilder WithWatt(Number watt);
    ICPUBuilder WithName(string componentName);
    ICPU Build();
}