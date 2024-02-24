using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.HDDs;

public interface IHDD : IHDDBuilderDirector, IComponent
{
    Number Capacity { get; }
    Number RotationSpeedOfQuil { get; }
    Number Watt { get; }
}