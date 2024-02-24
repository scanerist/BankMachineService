namespace Itmo.ObjectOrientedProgramming.Lab2.PersonalComputer;

public interface IPersonalComputerBuilderDIrector
{
    IPersonalComputerBuilder Direct(IPersonalComputerBuilder builder);
}