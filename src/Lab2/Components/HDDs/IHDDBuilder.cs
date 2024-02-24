using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.HDDs;

public interface IHDDBuilder
{
    IHDDBuilder WithCapacity(Number capacity);
    IHDDBuilder WithRotationSpeedOfQuil(Number rotationSpeedOfQUil);
    IHDDBuilder WithWatt(Number watt);
    IHDDBuilder WithName(string componentName);

    IHDD Build();
}