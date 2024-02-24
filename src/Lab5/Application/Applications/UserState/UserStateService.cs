using Contracts;
using Models;

namespace Applications.UserState;

public class UserStateService : IUserStateService
{
    public User? User { get; set; }
}