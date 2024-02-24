namespace Itmo.ObjectOrientedProgramming.Lab2.PowerSupplies;

public interface IPowerSupplyBuilderDirector
{
    IPowerSupplyBuilder Direct(IPowerSupplyBuilder builder);
}