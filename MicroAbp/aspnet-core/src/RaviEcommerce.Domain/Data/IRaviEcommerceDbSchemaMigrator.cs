using System.Threading.Tasks;

namespace RaviEcommerce.Data;

public interface IRaviEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
