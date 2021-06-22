using Streamlife.Mvp.Cms.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Streamlife.Mvp.Cms.Blazor
{
    public abstract class CmsComponentBase : AbpComponentBase
    {
        protected CmsComponentBase()
        {
            LocalizationResource = typeof(CmsResource);
        }
    }
}
