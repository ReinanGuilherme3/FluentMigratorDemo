using FluentMigrator;

namespace FluentMigratorDemo.Infrastructure.Migrations.Versions
{
    [Migration(DatabaseVersions.TALBE_CREATE_TRIGGER, "Criando trigger de auditoria na tabela Users")]
    public class Version2025062007 : ForwardOnlyMigration
    {
        public override void Up()
        {
            Execute.Sql(@"
            CREATE TRIGGER trg_Users_Insert
            ON Users
            AFTER INSERT
            AS
            BEGIN
                -- Exemplo: atualizar 'CreatedOn' com GETDATE() (pouco útil se já está sendo setado)
                UPDATE U
                SET CreatedOn = GETDATE()
                FROM Users U
                INNER JOIN inserted I ON U.Id = I.Id
            END
        ");
        }
    }
}
