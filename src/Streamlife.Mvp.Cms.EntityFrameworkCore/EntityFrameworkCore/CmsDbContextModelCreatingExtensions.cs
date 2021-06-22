using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Streamlife.Mvp.Cms.EntityFrameworkCore
{
    public static class CmsDbContextModelCreatingExtensions
    {
        public static void ConfigureCms(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(CmsConsts.DbTablePrefix + "YourEntities", CmsConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}