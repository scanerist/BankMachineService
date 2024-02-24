using System.Diagnostics.CodeAnalysis;
using Console.Scenarios;
using Contracts;

namespace Console.Providers;

public class AddMoneyScenarioProvider : IScenarioProvider
{
    private readonly IUserStateService _userStateService;
    private readonly IBankAccountService _bankAccountService;

    public AddMoneyScenarioProvider(IUserStateService userStateService, IBankAccountService bankAccountService)
    {
        _userStateService = userStateService;
        _bankAccountService = bankAccountService;
    }

    public bool TryGetScenario([NotNullWhen(true)] out IScenario? scenario)
    {
        if (_userStateService.User is null)
        {
            scenario = null;
            return false;
        }

        scenario = new AddMoneyScenario(_bankAccountService);
        return true;
    }
}