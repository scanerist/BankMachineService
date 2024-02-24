using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PersonalComputer;
using Itmo.ObjectOrientedProgramming.Lab2.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.Validation;

public interface IValidate<in T>
    where T : IComponent
{
    ResultType Validate(T componentOne);
}

public interface IValidateComputer<T>
{
    IList<ResultType?> ValidateComputer(IPersonalComputer computer);
}