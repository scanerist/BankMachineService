using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.BIOS.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs;
using Itmo.ObjectOrientedProgramming.Lab2.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab2.BIOS;

public interface IBios : IBiosBuilderDirector, IComponent, IValidate<ICPU>
{
    BiosType Type { get;  }
    BiosVersion BiosVersion { get; }
    IReadOnlyCollection<ICPU> ListOfAccesibleProcessors { get; }
}