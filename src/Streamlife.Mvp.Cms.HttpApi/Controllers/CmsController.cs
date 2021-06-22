using Streamlife.Mvp.Cms.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Streamlife.Mvp.Cms.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CmsController : AbpController
    {
        protected CmsController()
        {
            LocalizationResource = typeof(CmsResource);
        }
    }
}