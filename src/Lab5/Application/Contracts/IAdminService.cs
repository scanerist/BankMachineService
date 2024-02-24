using Models;

namespace Contracts;

public interface IAdminService
{
    OperationsResult Login(string username, string password);
    void CreateNewBankAccount(int pin, int accountNumber);
    void Logout();
}