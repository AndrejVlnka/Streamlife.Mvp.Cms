using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Streamlife.Mvp.Cms.Data;
using Volo.Abp.DependencyInjection;

namespace Streamlife.Mvp.Cms.EntityFrameworkCore
{
    public class EntityFrameworkCoreCmsDbSchemaMigrator
        : ICmsDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCmsDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CmsMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CmsMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}