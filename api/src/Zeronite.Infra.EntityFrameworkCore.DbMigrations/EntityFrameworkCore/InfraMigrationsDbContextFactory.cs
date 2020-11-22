using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Zeronite.Infra.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class InfraMigrationsDbContextFactory : IDesignTimeDbContextFactory<InfraMigrationsDbContext>
    {
        public InfraMigrationsDbContext CreateDbContext(string[] args)
        {
            InfraEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<InfraMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new InfraMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Zeronite.Infra.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
