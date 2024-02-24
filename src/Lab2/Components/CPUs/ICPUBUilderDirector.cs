namespace Itmo.ObjectOrientedProgramming.Lab2.CPUs;

public interface ICPUBuilderDirector
{
    ICPUBuilder Direct(ICPUBuilder builder);
}