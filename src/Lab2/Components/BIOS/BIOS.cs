using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.BIOS.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs;
using Itmo.ObjectOrientedProgramming.Lab2.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.BIOS;

public class BIOS : IBios
{
    public BIOS(BiosType type, BiosVersion biosVersion, IReadOnlyCollection<ICPU> listOfAccesibleProcessors, string componentName)
    {
        Type = type;
        BiosVersion = biosVersion;
        ListOfAccesibleProcessors = listOfAccesibleProcessors;
        ComponentName = componentName;
    }

    public BiosType Type { get; }
    public BiosVersion BiosVersion { get; }
    public IReadOnlyCollection<ICPU> ListOfAccesibleProcessors { get; }
    public string ComponentName { get; }

    public IBiosBuilder Direct(IBiosBuilder builder)
    {
        return builder.WithType(Type)
            .WithVersion(BiosVersion)
            .WithAccesibleCpus(ListOfAccesibleProcessors)
            .WithName(ComponentName);
    }

    public ResultType Validate(ICPU componentOne)
    {
        if (ListOfAccesibleProcessors.Any(processor => processor == componentOne))
        {
            return new Succes();
        }

        return new InvalidBuild();
    }
}