using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.SSDs;

public interface ISSDBuilder
{
    ISSDBuilder WithConnectionVAriant(ConnectionVariant variant);
    ISSDBuilder WithCapacity(Number capacity);
    ISSDBuilder WithMaxWorkSpeed(Number maxWorkSpeed);
    ISSDBuilder WithWatt(Number watt);
    ISSDBuilder BuilderWithName(string componentName);

    ISSD Build();
}