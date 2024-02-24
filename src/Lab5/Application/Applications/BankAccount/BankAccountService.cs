using Abstractions;
using Contracts;
using Models;

namespace Applications.BankAccount;

public class BankAccountService : IBankAccountService
{
    private readonly IBankAccountRepository _bankAccountRepository;
    private readonly IUserStateService _userStateService;
    private readonly ITransactionHistoryService _transactionHistoryService;

    public BankAccountService(IBankAccountRepository bankAccountRepository, IUserStateService userStateService, ITransactionHistoryService transactionHistoryService)
    {
        _bankAccountRepository = bankAccountRepository;
        _userStateService = userStateService;
        _transactionHistoryService = transactionHistoryService;
    }

    public OperationsResult Login(int bankAccount, int pin)
    {
        User? user = _bankAccountRepository.FindUser(bankAccount).Result;
        if (user?.Pin == pin)
        {
            _userStateService.User = user;
            return new OperationsResult.Success();
        }

        return new OperationsResult.Failure("user not found");
    }

    public int CheckBalance()
    {
        return _bankAccountRepository.CheckBalance(_userStateService.User?.BankAccount ?? 0).Result;
    }

    public OperationsResult AddMoney(int amount)
    {
        if (_userStateService.User is null)
        {
            return new OperationsResult.Failure("user not found");
        }

        _transactionHistoryService.AddHistory(OperationType.Increase, amount);
        _bankAccountRepository.AddMoney(_userStateService.User, amount);
        _userStateService.User.Balance += amount;
        return new OperationsResult.Success();
    }

    public OperationsResult WithdrawMoney(int amount)
    {
        if (_userStateService.User is null)
        {
            return new OperationsResult.Failure("user not found");
        }

        if (_userStateService.User.Balance < amount)
        {
            return new OperationsResult.Failure("insufficient balance");
        }

        _transactionHistoryService.AddHistory(OperationType.Decrease, amount);
        _bankAccountRepository.WithdrawMoney(_userStateService.User, amount);
        _userStateService.User.Balance -= amount;
        return new OperationsResult.Success();
    }

    public OperationsResult Logout()
    {
        _userStateService.User = null;
        return new OperationsResult.Success();
    }
}