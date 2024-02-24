using Abstractions;
using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Models;
using Npgsql;

namespace DataAccess.Repositories;

public class BankAccountRepository : IBankAccountRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;

    public BankAccountRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public async Task<User?> FindUser(int accountNumber)
    {
        const string sql = """
                           SELECT account_number, pin_code, balance
                           FROM bank_accounts
                           WHERE account_number = :accountNumber;
                           """;
        NpgsqlConnection connection = await _connectionProvider
            .GetConnectionAsync(default).ConfigureAwait(false);

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("accountNumber", accountNumber);
        using NpgsqlDataReader reader = await command.ExecuteReaderAsync().ConfigureAwait(false);
        if (await reader.ReadAsync().ConfigureAwait(false) is false)
            return null;

        return new User(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2));
    }

    public async Task<int> CheckBalance(int accountNumber)
    {
        const string sql = """
                           SELECT balance
                           FROM bank_accounts
                           WHERE account_number = :accountNumber;
                           """;
        NpgsqlConnection connection = await _connectionProvider
            .GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("accountNumber", accountNumber);
        using NpgsqlDataReader reader = await command.ExecuteReaderAsync().ConfigureAwait(false);
        return reader.GetInt32(0);
    }

    public async Task AddMoney(User? user, int amount)
    {
        const string sql = """
                           update bank_accounts
                           set balance = balance + :amount
                           where account_number = :accountNumber;
                           """;
        NpgsqlConnection connection = await _connectionProvider.GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("bankAccount", user?.BankAccount);
        command.AddParameter("amount", amount);
        using NpgsqlDataReader reader = await command.ExecuteReaderAsync().ConfigureAwait(false);
    }

    public async Task WithdrawMoney(User user, int amount)
    {
        const string sql = """
                           update bank_accounts
                           set balance = balance - :amount
                           where account_number = :accountNumber;
                           """;
        NpgsqlConnection connection = await _connectionProvider.GetConnectionAsync(default).ConfigureAwait(false);
        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("accountNumber", user.BankAccount);
        command.AddParameter("amount", amount);
        using NpgsqlDataReader reader = await command.ExecuteReaderAsync().ConfigureAwait(false);
    }
}