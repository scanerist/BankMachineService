using Abstractions;
using Contracts;
using Models;

namespace Applications.AdminService;

public class AdminService : IAdminService
{
    private readonly IAdminStateService _adminStateService;
    private readonly IAdminRepository _adminRepository;

    public AdminService(IAdminStateService adminStateService, IAdminRepository adminRepository)
    {
        _adminStateService = adminStateService;
        _adminRepository = adminRepository;
    }

    public OperationsResult Login(string username, string password)
    {
        Admin? admin = _adminRepository.FindAdmin(username).Result;
        if (admin?.Password == password)
        {
            return new OperationsResult.Success();
        }

        return new OperationsResult.Failure("You don't have permissions");
    }

    public void CreateNewBankAccount(int pin, int accountNumber)
    {
        _adminRepository.CreateNewBankAccount(accountNumber, pin);
    }

    public void Logout()
    {
        _adminStateService.Admin = null;
    }
}