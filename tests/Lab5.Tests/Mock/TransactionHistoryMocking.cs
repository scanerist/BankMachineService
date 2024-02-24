using System.Collections.Generic;
using System.Linq;
using Contracts;
using Models;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;

public class TransactionHistoryMocking : ITransactionHistoryService
{
    private readonly IDictionary<string, int> _history = new Dictionary<string, int>();

    public IAsyncEnumerable<Operation> ShowHistory()
    {
        return (IAsyncEnumerable<Operation>)new List<Operation>().AsEnumerable();
    }

    public void AddHistory(OperationType type, int amount)
    {
        _history.Add(type.ToString(), amount);
    }
}