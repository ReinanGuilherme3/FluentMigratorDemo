using FluentMigrator;

namespace FluentMigratorDemo.Infrastructure.Migrations.Versions;

[Migration(DatabaseVersions.TALBE_REMOVE_FUNCTION, "Removendo função fn_GetUserEmailById")]
public class Version2025062004 : ForwardOnlyMigration
{
    public override void Up()
    {
        Execute.Sql(@"DROP FUNCTION IF EXISTS fn_GetUserEmailById");
    }
}
