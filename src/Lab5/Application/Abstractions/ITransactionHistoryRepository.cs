using Models;

namespace Abstractions;

public interface ITransactionHistoryRepository
{
    void AddHistory(Operation operation);
    IAsyncEnumerable<Operation> ShowHistory(User user);
}