using Zeronite.Infra.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Zeronite.Infra
{
    [DependsOn(
        typeof(InfraEntityFrameworkCoreTestModule)
        )]
    public class InfraDomainTestModule : AbpModule
    {

    }
}