using System.Threading.Tasks;

namespace Zeronite.Infra.Data
{
    public interface IInfraDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
