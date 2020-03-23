using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Schoolmate.Data
{
    public class TemporarySchoolmateAuthDbContextFactory : IDesignTimeDbContextFactory<SchoolmateAuthDbContext>
    { 
        public SchoolmateAuthDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SchoolmateAuthDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=schlmate_auth;User Id=sa;Password=$$GiGatT777;");

            return new SchoolmateAuthDbContext(optionsBuilder.Options);
        }
    }

    public class TemporaryPersistedGrantDbContextFactory : IDesignTimeDbContextFactory<PersistedGrantDbContext>
    {
        public PersistedGrantDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PersistedGrantDbContext>();
            optionsBuilder
                .UseSqlServer("Server=localhost;Database=schlmate_auth;User Id=sa;Password=;",
                    builderOptions => builderOptions.MigrationsAssembly("Schoolmate.Data"));

            return new PersistedGrantDbContext(optionsBuilder.Options, new OperationalStoreOptions());
        }
    }

    public class TemporaryConfigurationDbContextFactory : IDesignTimeDbContextFactory<ConfigurationDbContext>
    {
        public ConfigurationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ConfigurationDbContext>();
            optionsBuilder
                .UseSqlServer("Server=localhost;Database=schlmate_auth;User Id=sa;Password=;",
                    builderOptions => builderOptions.MigrationsAssembly("Schoolmate.Data"));

            return new ConfigurationDbContext(optionsBuilder.Options, new ConfigurationStoreOptions());
        }
    }
}
