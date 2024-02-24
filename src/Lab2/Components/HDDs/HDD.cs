using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.HDDs;

public class HDD : IHDD
{
    public HDD(Number capacity, Number rotationSpeedOfQuil, Number watt, string componentName)
    {
        Capacity = capacity;
        RotationSpeedOfQuil = rotationSpeedOfQuil;
        Watt = watt;
        ComponentName = componentName;
    }

    public Number Capacity { get; }
    public Number RotationSpeedOfQuil { get; }
    public Number Watt { get; }
    public string ComponentName { get; }

    public IHDDBuilder Direct(IHDDBuilder builder)
    {
        return builder.WithRotationSpeedOfQuil(RotationSpeedOfQuil)
            .WithCapacity(Capacity)
            .WithWatt(Watt);
    }
}