namespace Itmo.ObjectOrientedProgramming.Lab2.CoolingSystems;

public interface ICoolingSystemBuilderDirector
{
    ICoolingSystemBuilder Direct(ICoolingSystemBuilder builder);
}