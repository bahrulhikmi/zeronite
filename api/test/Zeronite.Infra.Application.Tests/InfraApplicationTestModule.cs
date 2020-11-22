using Volo.Abp.Modularity;

namespace Zeronite.Infra
{
    [DependsOn(
        typeof(InfraApplicationModule),
        typeof(InfraDomainTestModule)
        )]
    public class InfraApplicationTestModule : AbpModule
    {

    }
}