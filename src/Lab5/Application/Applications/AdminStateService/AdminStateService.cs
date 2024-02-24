using Contracts;
using Models;

namespace Applications.AdminStateService;

public class AdminStateService : IAdminStateService
{
    public Admin? Admin { get; set; }
}