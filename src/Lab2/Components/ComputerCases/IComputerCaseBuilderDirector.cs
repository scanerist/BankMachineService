namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerCases;

public interface IComputerCaseBuilderDirector
{
    IComputerCaseBuilder Direct(IComputerCaseBuilder builder);
}