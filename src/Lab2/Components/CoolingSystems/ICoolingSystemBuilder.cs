using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.CoolingSystems;

public interface ICoolingSystemBuilder
{
    ICoolingSystemBuilder WithSizes(Number sizes);
    ICoolingSystemBuilder WithAccesibleSockets(IReadOnlyCollection<CpuSocket> sockets);
    ICoolingSystemBuilder WithTdp(Number tdp);
    ICoolingSystemBuilder WithName(string componentName);
    ICoolingSystem Build();
}