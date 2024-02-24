using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerCases;

public interface IComputerCaseBuilder
{
    IComputerCaseBuilder WithLength(Number length);
    IComputerCaseBuilder WithWidth(Number width);
    IComputerCaseBuilder WithFormFactors(IReadOnlyCollection<FormFactor> formFactors);
    IComputerCaseBuilder WithSizes(Number sizes);
    IComputerCaseBuilder WithName(string componentName);
    IComputerCase Build();
}