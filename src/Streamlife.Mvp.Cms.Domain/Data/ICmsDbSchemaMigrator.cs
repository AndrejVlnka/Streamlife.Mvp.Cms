using System.Threading.Tasks;

namespace Streamlife.Mvp.Cms.Data
{
    public interface ICmsDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
