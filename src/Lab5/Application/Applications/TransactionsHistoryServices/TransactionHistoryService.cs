using Abstractions;
using Contracts;
using Models;

namespace Applications.TransactionsHistoryServices;

public class TransactionHistoryService : ITransactionHistoryService
{
    private readonly ITransactionHistoryRepository _historyRepository;
    private readonly IUserStateService _userStateService;

    public TransactionHistoryService(ITransactionHistoryRepository historyRepository, IUserStateService userStateService)
    {
        _historyRepository = historyRepository;
        _userStateService = userStateService;
    }

    public IAsyncEnumerable<Operation> ShowHistory()
    {
        if (_userStateService.User == null)
        {
            return (IAsyncEnumerable<Operation>)new List<Operation>().AsEnumerable();
        }

        return _historyRepository.ShowHistory(_userStateService.User);
    }

    public void AddHistory(OperationType type, int amount)
    {
        _historyRepository.AddHistory(new Operation(type, amount));
    }
}