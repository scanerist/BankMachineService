using Contracts;
using Models;
using Spectre.Console;

namespace Console.Scenarios;

public class WithdrawMoneyScenario : IScenario
{
    private readonly IBankAccountService _bankAccountService;

    public WithdrawMoneyScenario(IBankAccountService bankAccountService)
    {
        _bankAccountService = bankAccountService;
    }

    public string Name => "Withdraw money";
    public void Run()
    {
        int amount = AnsiConsole.Ask<int>("Enter amount");
        OperationsResult result = _bankAccountService.WithdrawMoney(amount);
        string message = result switch
        {
            OperationsResult.Success => "Money withdrawn",
            OperationsResult.Failure => "Money not withdrawn, something went wrong",
            _ => throw new ArgumentOutOfRangeException(nameof(amount)),
        };
        AnsiConsole.WriteLine(message);
        AnsiConsole.WriteLine("Ok");
    }
}