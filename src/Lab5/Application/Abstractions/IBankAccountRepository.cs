using Models;

namespace Abstractions;

public interface IBankAccountRepository
{
    Task<User?> FindUser(int accountNumber);
    Task<int> CheckBalance(int accountNumber);
    Task AddMoney(User? user, int amount);
    Task WithdrawMoney(User user, int amount);
}