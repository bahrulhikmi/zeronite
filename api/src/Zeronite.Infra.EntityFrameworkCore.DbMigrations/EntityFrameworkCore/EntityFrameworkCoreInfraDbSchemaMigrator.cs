using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Zeronite.Infra.Data;
using Volo.Abp.DependencyInjection;

namespace Zeronite.Infra.EntityFrameworkCore
{
    public class EntityFrameworkCoreInfraDbSchemaMigrator
        : IInfraDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreInfraDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the InfraMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<InfraMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}