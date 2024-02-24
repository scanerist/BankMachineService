using Contracts;
using Models;
using Spectre.Console;

namespace Console.Scenarios;

public class LoginScenario : IScenario
{
    private readonly IBankAccountService _bankAccountService;

    public LoginScenario(IBankAccountService bankAccountService)
    {
        _bankAccountService = bankAccountService;
    }

    public string Name => "Login";

    public void Run()
    {
        int username = AnsiConsole.Ask<int>("Enter your username");
        int pin = AnsiConsole.Ask<int>("Enter your pin");

        OperationsResult result = _bankAccountService.Login(username, pin);

        string message = result switch
        {
            OperationsResult.Success => "Successful login",
            OperationsResult.Failure => "User not found",
            _ => throw new ArgumentOutOfRangeException(nameof(result)),
        };

        AnsiConsole.WriteLine(message);
        AnsiConsole.Ask<string>("Ok");
    }
}