using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace RaviEcommerce.Data;

/* This is used if database provider does't define
 * IRaviEcommerceDbSchemaMigrator implementation.
 */
public class NullRaviEcommerceDbSchemaMigrator : IRaviEcommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
