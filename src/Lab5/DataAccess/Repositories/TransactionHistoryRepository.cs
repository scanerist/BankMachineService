using Abstractions;
using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Models;
using Npgsql;

namespace DataAccess.Repositories;

public class TransactionHistoryRepository : ITransactionHistoryRepository
{
    private IPostgresConnectionProvider _connectionProvider;

    public TransactionHistoryRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public async void AddHistory(Operation operation)
    {
        const string sql = """
                           INSERT INTO
                           history_operation(account_number, history, amount)
                           VALUES(:account_number, :history, :amount);
                           """;
        NpgsqlConnection connection = await _connectionProvider
            .GetConnectionAsync(default).ConfigureAwait(false);

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("history", operation.Type);
        command.AddParameter("amount", operation.Money);
        command.ExecuteNonQuery();
    }

    public async IAsyncEnumerable<Operation> ShowHistory(User user)
    {
        const string sql = """
                           select account_number, history, amount
                           from history_operation
                           where account_number = :account_number;
                           """;
        NpgsqlConnection connection = await _connectionProvider
            .GetConnectionAsync(default).ConfigureAwait(false);

        using var command = new NpgsqlCommand(sql, connection);
        command.AddParameter("account_number", user.BankAccount);
        using NpgsqlDataReader reader = await command.ExecuteReaderAsync().ConfigureAwait(false);

        while (await reader.ReadAsync(default).ConfigureAwait(false) is false)
        {
            yield return new Operation(
                await reader.GetFieldValueAsync<OperationType>(1).ConfigureAwait(false),
                reader.GetInt32(2));
        }
    }
}