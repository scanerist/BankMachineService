using System.Collections.Generic;

using Itmo.ObjectOrientedProgramming.Lab2.PersonalComputer;
using Itmo.ObjectOrientedProgramming.Lab2.Results;

namespace Itmo.ObjectOrientedProgramming.Lab2.Validation;

public class Validation : IValidateComputer<IPersonalComputer>
{
    private IList<ResultType?> _result;
    public Validation(IList<ResultType?> result)
    {
        _result = result;
    }

    public IList<ResultType?> ValidateComputer(IPersonalComputer computer)
    {
        _result.Add(computer.ComputerCase?.Validate(computer.MotherBoard));
        _result.Add(computer.CoolingSystem.Validate(computer.Cpu));
        _result.Add(computer.Bios?.Validate(computer.Cpu));
        _result.Add(computer.MotherBoard.Validate(computer.Cpu));
        _result.Add(computer.Ram.Validate(computer.MotherBoard));
        _result.Add(computer.VideoGraphicCard.Validate(computer.MotherBoard));
        if (computer.ComputerCase is not null)
        {
            _result.Add(computer.VideoGraphicCard.Validate(computer.ComputerCase));
        }

        if (computer.WifiModule is not not null)
        {
            _result.Add(computer.WifiModule?.Validate(computer.MotherBoard));
        }

        return _result;
    }
}