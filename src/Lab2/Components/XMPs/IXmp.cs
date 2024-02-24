using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.XMPs;

public interface IXmp : IXmpBuilderDirector, IComponent
{
    Number Timing { get; }
    Number Voltage { get; }
    Number Frequency { get; }
}