using Itmo.ObjectOrientedProgramming.Lab2.Services;
namespace Itmo.ObjectOrientedProgramming.Lab2.SSDs;

public interface ISSD : ISSDBuilderDIrector, IComponent
{
    ConnectionVariant Variant { get; }
    Number Capacity { get; }
    Number MaxWorkSpeed { get; }
    Number Watt { get; }
}