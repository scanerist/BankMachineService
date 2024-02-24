using Console.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace Console.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddPresentationConsole(this IServiceCollection collection)
    {
        collection.AddScoped<ScenarioRunner>();

        collection.AddScoped<IScenarioProvider, LoginScenarioProvider>();
        collection.AddScoped<IScenarioProvider, WithdrawMoneyScenarioProvider>();
        collection.AddScoped<IScenarioProvider, ShowHistoryScenarioProvider>();
        collection.AddScoped<IScenarioProvider, LogoutScenarioProvider>();
        collection.AddScoped<IScenarioProvider, AddNewBankAccountScenarioProvider>();
        collection.AddScoped<IScenarioProvider, AddMoneyScenarioProvider>();

        return collection;
    }
}