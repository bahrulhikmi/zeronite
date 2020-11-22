using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Zeronite.Infra.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(InfraHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class InfraConsoleApiClientModule : AbpModule
    {
        
    }
}
