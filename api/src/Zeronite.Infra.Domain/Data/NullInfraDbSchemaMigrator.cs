using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Zeronite.Infra.Data
{
    /* This is used if database provider does't define
     * IInfraDbSchemaMigrator implementation.
     */
    public class NullInfraDbSchemaMigrator : IInfraDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}