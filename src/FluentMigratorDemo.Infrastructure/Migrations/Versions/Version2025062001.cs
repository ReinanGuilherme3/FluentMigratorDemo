using FluentMigrator;

namespace FluentMigratorDemo.Infrastructure.Migrations.Versions;

[Migration(DatabaseVersions.TALBE_REGISTER_USER, "Criando tabela usuario")]
public class Version2025062001 : ForwardOnlyMigration
{
    public override void Up()
    {
        Create.Table("Users")
            .WithColumn("Id").AsGuid().PrimaryKey().NotNullable()
            .WithColumn("Active").AsBoolean().NotNullable().WithDefaultValue(true)
            .WithColumn("CreatedOn").AsDateTime().NotNullable()
            .WithColumn("Name").AsString(255).NotNullable().Unique()
            .WithColumn("Email").AsString(255).NotNullable().Unique()
            .WithColumn("Password").AsString(2000).NotNullable();
    }
}
