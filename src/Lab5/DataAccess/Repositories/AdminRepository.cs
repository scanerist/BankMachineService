using Abstractions;
using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Models;
using Npgsql;

namespace DataAccess.Repositories;

public class AdminRepository : IAdminRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;

    public AdminRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public async Task<Admin?> FindAdmin(string adminName)
    {
        const string sql = """
                           select admin_name, admin_password
                           from admins
                           where admin_name = :adminName;
                           """;
        NpgsqlConnection connection = await _connectionProvider
            .GetConnectionAsync(default).ConfigureAwait(false);

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("adminName", adminName);

        using NpgsqlDataReader reader = await command.ExecuteReaderAsync().ConfigureAwait(false);

        if (await reader.ReadAsync().ConfigureAwait(false) is false)
            return null;

        return new Admin(
            reader.GetString(0), reader.GetString(1));
    }

    public async void CreateNewBankAccount(int accountNumber, int pin)
    {
        const string sql = """
                           INSERT INTO 
                           bank_accounts(account_number, pin_code, balance)
                           VALUES(:accountNumber, :pin, 0);
                           """;
        NpgsqlConnection connection = await _connectionProvider
            .GetConnectionAsync(default).ConfigureAwait(false);

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("accountNumber", accountNumber);
        command.AddParameter("pin", pin);
        command.AddParameter("balance", 0);
        command.ExecuteNonQuery();
    }
}