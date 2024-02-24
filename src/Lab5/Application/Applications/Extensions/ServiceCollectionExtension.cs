using Applications.BankAccount;
using Applications.TransactionsHistoryServices;
using Applications.UserState;
using Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Applications.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<IAdminService, AdminService.AdminService>();
        collection.AddScoped<IAdminStateService, AdminStateService.AdminStateService>();
        collection.AddScoped<IBankAccountService, BankAccountService>();
        collection.AddScoped<ITransactionHistoryService, TransactionHistoryService>();
        collection.AddScoped<UserStateService>();
        collection.AddScoped<IUserStateService>(
            p => p.GetRequiredService<UserStateService>());

        return collection;
    }
}