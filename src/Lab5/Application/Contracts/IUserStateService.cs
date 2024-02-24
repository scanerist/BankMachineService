using Models;

namespace Contracts;

public interface IUserStateService
{
    User? User { get; set; }
}