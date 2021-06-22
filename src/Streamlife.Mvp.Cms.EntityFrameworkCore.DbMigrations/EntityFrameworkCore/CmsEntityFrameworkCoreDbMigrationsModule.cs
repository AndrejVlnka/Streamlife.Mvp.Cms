using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Streamlife.Mvp.Cms.EntityFrameworkCore
{
    [DependsOn(
        typeof(CmsEntityFrameworkCoreModule)
        )]
    public class CmsEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CmsMigrationsDbContext>();
        }
    }
}
