using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.Results;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.CoolingSystems;

public class CoolingSystem : ICoolingSystem
{
    public CoolingSystem(Number sizes, IReadOnlyCollection<CpuSocket> accesibleSockets, Number tdp, string componentName)
    {
        Sizes = sizes;
        AccesibleSockets = accesibleSockets;
        Tdp = tdp;
        ComponentName = componentName;
    }

    public Number Sizes { get; }
    public IReadOnlyCollection<CpuSocket> AccesibleSockets { get; }
    public Number Tdp { get; }
    public string ComponentName { get; }
    public ICoolingSystemBuilder Direct(ICoolingSystemBuilder builder)
    {
        return builder.WithSizes(Sizes)
            .WithAccesibleSockets(AccesibleSockets)
            .WithTdp(Tdp);
    }

    public ResultType Validate(ICPU componentOne)
    {
        if (AccesibleSockets.Any(socket => socket == componentOne.Socket) && componentOne.Tdp == Tdp)
        {
            return new Succes();
        }

        return new InvalidBuild();
    }
}