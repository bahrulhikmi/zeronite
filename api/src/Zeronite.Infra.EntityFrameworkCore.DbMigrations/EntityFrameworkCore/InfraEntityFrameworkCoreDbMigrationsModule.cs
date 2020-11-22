using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Zeronite.Infra.EntityFrameworkCore
{
    [DependsOn(
        typeof(InfraEntityFrameworkCoreModule)
        )]
    public class InfraEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<InfraMigrationsDbContext>();
        }
    }
}
