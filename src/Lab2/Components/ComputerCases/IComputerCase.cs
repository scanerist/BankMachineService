using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerCases;

public interface IComputerCase : IComputerCaseBuilderDirector, IComponent, IValidate<IMotherBoard>
{
    Number Length { get; }
    Number Width { get; }
    IReadOnlyCollection<FormFactor> FormFactors { get; }
    Number Sizes { get; }
}