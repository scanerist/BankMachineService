using Models;

namespace Abstractions;

public interface IAdminRepository
{
      Task<Admin?> FindAdmin(string adminName);
      void CreateNewBankAccount(int accountNumber, int pin);
}