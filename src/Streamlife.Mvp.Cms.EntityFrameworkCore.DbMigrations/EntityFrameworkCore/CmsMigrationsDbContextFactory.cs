using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Streamlife.Mvp.Cms.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class CmsMigrationsDbContextFactory : IDesignTimeDbContextFactory<CmsMigrationsDbContext>
    {
        public CmsMigrationsDbContext CreateDbContext(string[] args)
        {
            CmsEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<CmsMigrationsDbContext>()
                .UseSqlite(configuration.GetConnectionString("Default"));

            return new CmsMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Streamlife.Mvp.Cms.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
