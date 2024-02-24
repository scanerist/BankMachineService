using FluentMigrator;
using Itmo.Dev.Platform.Postgres.Migrations;

namespace DataAccess.Migrations;

[Migration(1, "Initial")]
public class Initial : SqlMigration
{
    protected override string GetUpSql(IServiceProvider serviceProvider) =>
        """
        create table bank_accounts
        (
            user_id bigint primary key generated always as identity ,
            account_number int not null ,
            pin_code int not null,
            balance int not null
        );
        create table admins
        (
            admin_id bigint primary key generated always as identity ,
            admin_name varchar not null ,  
            admin_password varchar not null  
        );
        
        create type history_type as enum
        (
            'Increase',  
            'Decrease'   
        );
        
        create table history_operation
        (
           account_number int not null ,
           history history_type not null ,
           amount int not null
        );

        INSERT INTO
        bank_accounts(account_number, pin_code, balance)
        VALUES(1488, 1337, 1245);
        
        """;

    protected override string GetDownSql(IServiceProvider serviceProvider) =>
        """
        drop table admins;
        drop table bank_accounts;
        drop table history_operation;
        """;
}