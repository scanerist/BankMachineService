namespace Models;

public class User
{
    public User(int bankAccount, int pin, int balance)
    {
        BankAccount = bankAccount;
        Pin = pin;
        Balance = balance;
    }

    public int BankAccount { get; set; }
    public int Pin { get; set; }
    public int Balance { get; set; }
}