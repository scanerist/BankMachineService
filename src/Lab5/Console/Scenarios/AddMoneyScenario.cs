using Contracts;
using Models;
using Spectre.Console;

namespace Console.Scenarios;

public class AddMoneyScenario : IScenario
{
    private readonly IBankAccountService _bankAccountService;

    public AddMoneyScenario(IBankAccountService bankAccountService)
    {
        _bankAccountService = bankAccountService;
    }

    public string Name => "Add money";
    public void Run()
    {
        int amount = AnsiConsole.Ask<int>("Enter amount");
        OperationsResult result = _bankAccountService.AddMoney(amount);
        string message = result switch
        {
            OperationsResult.Success => "Money added",
            OperationsResult.Failure => "Money not added, something went wrong",
            _ => throw new ArgumentOutOfRangeException(nameof(amount)),
        };
        AnsiConsole.WriteLine(message);
        AnsiConsole.WriteLine("Ok");
    }
}