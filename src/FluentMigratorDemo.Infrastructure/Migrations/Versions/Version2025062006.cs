using FluentMigrator;
using FluentMigratorDemo.Infrastructure.Migrations;

[Migration(DatabaseVersions.TALBE_UPDATE_REMOVE_EMAIL_ADD_TELEFONE, "Removendo campo Email e adicionando Telefone na tabela Users")]
public class Version2025062006 : ForwardOnlyMigration
{
    public override void Up()
    {
        // Remove o índice que depende da coluna 'Email'
        Execute.Sql(@"
            IF EXISTS (
                SELECT 1
                FROM sys.indexes
                WHERE name = 'IX_Users_Email'
                AND object_id = OBJECT_ID('[dbo].[Users]')
            )
            BEGIN
                DROP INDEX [IX_Users_Email] ON [dbo].[Users]
            END
        ");

        // Agora pode remover a coluna
        Delete.Column("Email").FromTable("Users");

        // E adicionar a nova coluna 'Telefone'
        Alter.Table("Users")
            .AddColumn("Telefone").AsString(20).Nullable();
    }
}
