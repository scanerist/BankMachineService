using Models;

namespace Contracts;

public interface IBankAccountService
{
    OperationsResult Login(int bankAccount, int pin);
    int CheckBalance();
    OperationsResult AddMoney(int amount);
    OperationsResult WithdrawMoney(int amount);
    OperationsResult Logout();
}