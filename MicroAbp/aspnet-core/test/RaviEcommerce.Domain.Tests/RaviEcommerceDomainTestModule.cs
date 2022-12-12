using RaviEcommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace RaviEcommerce;

[DependsOn(
    typeof(RaviEcommerceEntityFrameworkCoreTestModule)
    )]
public class RaviEcommerceDomainTestModule : AbpModule
{

}
