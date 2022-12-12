using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RaviEcommerce.Data;
using Volo.Abp.DependencyInjection;

namespace RaviEcommerce.EntityFrameworkCore;

public class EntityFrameworkCoreRaviEcommerceDbSchemaMigrator
    : IRaviEcommerceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreRaviEcommerceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the RaviEcommerceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<RaviEcommerceDbContext>()
            .Database
            .MigrateAsync();
    }
}
