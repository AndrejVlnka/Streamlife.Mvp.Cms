using System;
using System.Collections.Generic;
using System.Text;
using Streamlife.Mvp.Cms.Localization;
using Volo.Abp.Application.Services;

namespace Streamlife.Mvp.Cms
{
    /* Inherit your application services from this class.
     */
    public abstract class CmsAppService : ApplicationService
    {
        protected CmsAppService()
        {
            LocalizationResource = typeof(CmsResource);
        }
    }
}
