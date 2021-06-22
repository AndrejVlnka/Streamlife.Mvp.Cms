using Streamlife.Mvp.Cms.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Streamlife.Mvp.Cms
{
    [DependsOn(
        typeof(CmsEntityFrameworkCoreTestModule)
        )]
    public class CmsDomainTestModule : AbpModule
    {

    }
}