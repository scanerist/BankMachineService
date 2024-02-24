using System.Collections.Generic;
using Applications.BankAccount;
using Models;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;

public class BankingSystemTest
{
    [Fact]
    public void AddMoneyToAccount()
    {
        var repository = new BankAccountMocking(new Dictionary<int, User>
        {
            { 1, new User(1, 1234, 100) },
        });
        var transactionHistoryService = new TransactionHistoryMocking();
        var userStateServiceMocking = new UserStateServiceMocking();
        var service = new BankAccountService(repository, userStateServiceMocking, transactionHistoryService);
        OperationsResult result = service.AddMoney(100);
        Assert.IsType<OperationsResult.Success>(result);
    }

    [Fact]
    public void WithdrawMoneyFromAccount()
    {
        var repository = new BankAccountMocking(new Dictionary<int, User>
        {
            { 1, new User(1, 1234, 100) },
        });
        var transactionHistoryService = new TransactionHistoryMocking();
        var userStateServiceMocking = new UserStateServiceMocking();
        var service = new BankAccountService(repository, userStateServiceMocking, transactionHistoryService);
        OperationsResult result = service.WithdrawMoney(100);
        Assert.IsType<OperationsResult.Success>(result);
    }

    [Fact]
    public void WithdrawMoneyFromAccoountFailure()
    {
        var repository = new BankAccountMocking(new Dictionary<int, User>
        {
            { 1, new User(1, 1234, 100) },
        });
        var transactionHistoryService = new TransactionHistoryMocking();
        var userStateServiceMocking = new UserStateServiceMocking();
        var service = new BankAccountService(repository, userStateServiceMocking, transactionHistoryService);
        OperationsResult result = service.WithdrawMoney(101);
        Assert.IsType<OperationsResult.Failure>(result);
    }
}