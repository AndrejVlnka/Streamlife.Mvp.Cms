using Volo.Abp.Modularity;

namespace Streamlife.Mvp.Cms
{
    [DependsOn(
        typeof(CmsApplicationModule),
        typeof(CmsDomainTestModule)
        )]
    public class CmsApplicationTestModule : AbpModule
    {

    }
}