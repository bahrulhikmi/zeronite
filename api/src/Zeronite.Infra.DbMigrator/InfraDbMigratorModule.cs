using Zeronite.Infra.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Zeronite.Infra.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(InfraEntityFrameworkCoreDbMigrationsModule),
        typeof(InfraApplicationContractsModule)
        )]
    public class InfraDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
