using FluentMigrator;

namespace FluentMigratorDemo.Infrastructure.Migrations.Versions;

[Migration(DatabaseVersions.TALBE_CREATE_PROC_FUNC, "Criando procedure e function de usuários")]
public class Version2025062003 : ForwardOnlyMigration
{
    public override void Up()
    {
        // Criar Procedure
        Execute.Sql(@"
            CREATE PROCEDURE usp_InsertUser
                @Id UNIQUEIDENTIFIER,
                @Name NVARCHAR(255),
                @Email NVARCHAR(255),
                @Password NVARCHAR(2000)
            AS
            BEGIN
                INSERT INTO Users (Id, Active, CreatedOn, Name, Email, Password)
                VALUES (@Id, 1, GETDATE(), @Name, @Email, @Password)
            END
        ");

        // Criar Function
        Execute.Sql(@"
            CREATE FUNCTION fn_GetUserEmailById
            (
                @UserId UNIQUEIDENTIFIER
            )
            RETURNS NVARCHAR(255)
            AS
            BEGIN
                DECLARE @Email NVARCHAR(255)
                SELECT @Email = Email FROM Users WHERE Id = @UserId
                RETURN @Email
            END
        ");
    }
}

