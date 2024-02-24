using Contracts;
using Spectre.Console;

namespace Console.Scenarios;

public class ShowHistoryScenario : IScenario
{
    private readonly ITransactionHistoryService _transactionHistoryService;

    public ShowHistoryScenario(ITransactionHistoryService transactionHistoryService)
    {
        _transactionHistoryService = transactionHistoryService;
    }

    public string Name => "Show history";

    public void Run()
    {
        _transactionHistoryService.ShowHistory();
        AnsiConsole.Ask<string>("Ok");
    }
}