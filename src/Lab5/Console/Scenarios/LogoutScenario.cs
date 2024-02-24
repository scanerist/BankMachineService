using Contracts;
using Spectre.Console;

namespace Console.Scenarios;

public class LogoutScenario : IScenario
{
    private readonly IBankAccountService _bankAccountService;

    public LogoutScenario(IBankAccountService bankAccountService)
    {
        _bankAccountService = bankAccountService;
    }

    public string Name => "Logout";

    public void Run()
    {
        _bankAccountService.Logout();
        AnsiConsole.WriteLine("Ok");
    }
}