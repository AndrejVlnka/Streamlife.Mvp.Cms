using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Streamlife.Mvp.Cms
{
    [Dependency(ReplaceServices = true)]
    public class CmsBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Cms";
    }
}
