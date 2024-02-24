using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abstractions;
using Models;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;

public class BankAccountMocking : IBankAccountRepository
{
    private IDictionary<int, User> _dictionary;

    public BankAccountMocking(IDictionary<int, User> dictionary)
    {
        _dictionary = dictionary;
    }

    public Task<User?> FindUser(int accountNumber)
    {
        if (_dictionary.TryGetValue(accountNumber, out User? value))
        {
            return Task.FromResult(value.BankAccount == accountNumber ? value : null);
        }

        return Task.FromResult<User?>(null);
    }

    public Task<int> CheckBalance(int accountNumber)
    {
        if (_dictionary.TryGetValue(accountNumber, out User? value))
        {
            return Task.FromResult(value.Balance);
        }

        return Task.FromResult(0);
    }

    public Task WithdrawMoney(User user, int amount)
    {
        if (user.Balance >= amount)
        {
            user.Balance -= amount;
        }

        return Task.CompletedTask;
    }

    public Task AddMoney(User? user, int amount)
    {
        if (user != null)
        {
            user.Balance += amount;
        }

        return Task.CompletedTask;
    }
}