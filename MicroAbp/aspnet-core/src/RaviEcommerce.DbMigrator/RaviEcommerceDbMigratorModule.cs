using RaviEcommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace RaviEcommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(RaviEcommerceEntityFrameworkCoreModule),
    typeof(RaviEcommerceApplicationContractsModule)
    )]
public class RaviEcommerceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
