using Contracts;
using Models;
using Spectre.Console;

namespace Console.Scenarios;

public class AddNewBankAccountScenario : IScenario
{
    private readonly IAdminService _adminService;

    public AddNewBankAccountScenario(IAdminService adminService)
    {
        _adminService = adminService;
    }

    public string Name => "Add new bank account";

    public void Run()
    {
        string username = AnsiConsole.Ask<string>("Enter username");
        string password = AnsiConsole.Ask<string>("Enter password");
        OperationsResult result = _adminService.Login(username, password);
        if (result is OperationsResult.Failure == false)
        {
            int accountNumber = AnsiConsole.Ask<int>("Enter account number");
            int pin = AnsiConsole.Ask<int>("Enter pin");

            _adminService.CreateNewBankAccount(pin, accountNumber);
            AnsiConsole.WriteLine("new bank account created");
            AnsiConsole.Ask<string>("Ok");
        }
        else
        {
            AnsiConsole.WriteLine("You are not admin");
            AnsiConsole.Ask<string>("Ok");
        }
    }
}