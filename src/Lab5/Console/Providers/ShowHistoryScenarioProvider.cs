using System.Diagnostics.CodeAnalysis;
using Console.Scenarios;
using Contracts;

namespace Console.Providers;

public class ShowHistoryScenarioProvider : IScenarioProvider
{
    private readonly IUserStateService _userStateService;
    private readonly ITransactionHistoryService _transactionHistoryService;

    public ShowHistoryScenarioProvider(IUserStateService userStateService, ITransactionHistoryService transactionHistoryService)
    {
        _userStateService = userStateService;
        _transactionHistoryService = transactionHistoryService;
    }

    public bool TryGetScenario([NotNullWhen(true)]out IScenario? scenario)
    {
        if (_userStateService.User is null)
        {
            scenario = null;
            return false;
        }

        scenario = new ShowHistoryScenario(_transactionHistoryService);
        return true;
    }
}