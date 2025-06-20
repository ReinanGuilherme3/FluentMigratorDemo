using FluentMigrator;

namespace FluentMigratorDemo.Infrastructure.Migrations.Versions;


[Migration(DatabaseVersions.TALBE_UPDATE_PROCEDURE, "Atualizando procedure usp_InsertUser")]
public class Version2025062005 : ForwardOnlyMigration
{
    public override void Up()
    {
        // Drop da procedure existente
        Execute.Sql(@"
            DROP PROCEDURE dbo.usp_InsertUser;
        ");

        // Criação da nova versão da procedure
        Execute.Sql(@"
            CREATE PROCEDURE usp_InsertUser
                @Id UNIQUEIDENTIFIER,
                @Name NVARCHAR(255),
                @Email NVARCHAR(255),
                @Password NVARCHAR(2000),
                @Active BIT
            AS
            BEGIN
                INSERT INTO Users (Id, Active, CreatedOn, Name, Email, Password)
                VALUES (@Id, @Active, GETDATE(), @Name, @Email, @Password)
            END
        ");
    }
}
