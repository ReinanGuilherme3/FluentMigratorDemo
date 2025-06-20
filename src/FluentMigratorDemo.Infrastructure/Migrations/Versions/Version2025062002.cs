using FluentMigrator;

namespace FluentMigratorDemo.Infrastructure.Migrations.Versions;


[Migration(DatabaseVersions.TALBE_INSERT_USER, "Inserindo primeiro usuário")]
public class Version2025062002 : ForwardOnlyMigration
{
    public override void Up()
    {
        Insert.IntoTable("Users").Row(new
        {
            Id = Guid.CreateVersion7(),
            Active = true,
            CreatedOn = DateTime.UtcNow,
            Name = "Administrador",
            Email = "admin@example.com",
            Password = "senha_criptografada"
        });
    }
}

