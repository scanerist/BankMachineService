using Models;

namespace Contracts;

public interface ITransactionHistoryService
{
    IAsyncEnumerable<Operation> ShowHistory();
    void AddHistory(OperationType type, int amount);
}