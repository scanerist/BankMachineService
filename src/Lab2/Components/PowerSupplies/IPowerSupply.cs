using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PowerSupplies;

public interface IPowerSupply : IPowerSupplyBuilderDirector, IComponent
{
    Number PeakLoad { get; }
}