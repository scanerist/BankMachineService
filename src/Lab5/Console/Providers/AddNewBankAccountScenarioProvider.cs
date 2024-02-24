using System.Diagnostics.CodeAnalysis;
using Console.Scenarios;
using Contracts;

namespace Console.Providers;

public class AddNewBankAccountScenarioProvider : IScenarioProvider
{
    private readonly IUserStateService _userStateService;
    private readonly IAdminService _adminService;

    public AddNewBankAccountScenarioProvider(IUserStateService userStateService, IAdminService adminService)
    {
        _userStateService = userStateService;
        _adminService = adminService;
    }

    public bool TryGetScenario([NotNullWhen(true)] out IScenario? scenario)
    {
        if (_userStateService.User is not null)
        {
            scenario = null;
            return false;
        }

        scenario = new AddNewBankAccountScenario(_adminService);
        return true;
    }
}