using Contracts;
using Models;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;

public class UserStateServiceMocking : IUserStateService
{
    public User? User { get; set; }
}