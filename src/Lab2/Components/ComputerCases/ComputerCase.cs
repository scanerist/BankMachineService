using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Results;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerCases;

public class ComputerCase : IComputerCase
{
    public ComputerCase(Number length, Number width, IReadOnlyCollection<FormFactor> formFactors, Number sizes, string componentName)
    {
        Length = length;
        Width = width;
        FormFactors = formFactors;
        Sizes = sizes;
        ComponentName = componentName;
    }

    public Number Length { get; }
    public Number Width { get; }
    public IReadOnlyCollection<FormFactor> FormFactors { get; }
    public Number Sizes { get; }
    public string ComponentName { get; }
    public IComputerCaseBuilder Direct(IComputerCaseBuilder builder)
    {
        return builder.WithLength(Length)
            .WithSizes(Sizes)
            .WithWidth(Width)
            .WithFormFactors(FormFactors);
    }

    public ResultType Validate(IMotherBoard componentOne)
    {
        if (FormFactors.Any(processors => processors == componentOne.FormFactor))
        {
            return new Succes();
        }

        return new InvalidBuild();
    }
}