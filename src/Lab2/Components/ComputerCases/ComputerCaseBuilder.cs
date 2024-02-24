using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerCases;

public class ComputerCaseBuilder : IComputerCaseBuilder
{
    private Number? _length;
    private Number? _width;
    private IReadOnlyCollection<FormFactor>? _formFactors;
    private Number? _sizes;
    private string? _componentName;
    public IComputerCaseBuilder WithLength(Number length)
    {
         _length = length;
         return this;
    }

    public IComputerCaseBuilder WithWidth(Number width)
    {
         _width = width;
         return this;
    }

    public IComputerCaseBuilder WithFormFactors(IReadOnlyCollection<FormFactor> formFactors)
    {
         _formFactors = formFactors;
         return this;
    }

    public IComputerCaseBuilder WithSizes(Number sizes)
    {
         _sizes = sizes;
         return this;
    }

    public IComputerCaseBuilder WithName(string componentName)
    {
         _componentName = componentName;
         return this;
    }

    public IComputerCase Build()
    {
         return new ComputerCase(
              _length ?? throw new ArgumentNullException(nameof(_length)),
              _width ?? throw new ArgumentNullException(nameof(_width)),
              _formFactors ?? throw new ArgumentNullException(nameof(_formFactors)),
              _sizes ?? throw new ArgumentNullException(nameof(_sizes)),
              _componentName ?? throw new ArgumentNullException(nameof(_componentName)));
    }
}