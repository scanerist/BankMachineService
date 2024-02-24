using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.BIOS.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs;

namespace Itmo.ObjectOrientedProgramming.Lab2.BIOS;

public interface IBiosBuilder
{
    IBiosBuilder WithType(BiosType type);
    IBiosBuilder WithVersion(BiosVersion biosVersion);
    IBiosBuilder WithAccesibleCpus(IReadOnlyCollection<ICPU> processors);
    IBiosBuilder WithName(string componentName);
    IBios Build();
}