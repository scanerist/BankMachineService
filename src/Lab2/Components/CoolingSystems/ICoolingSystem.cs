using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab2.CoolingSystems;

public interface ICoolingSystem : ICoolingSystemBuilderDirector, IComponent, IValidate<ICPU>
{
    Number Sizes { get; }
    IReadOnlyCollection<CpuSocket> AccesibleSockets { get; }
    Number Tdp { get; }
}