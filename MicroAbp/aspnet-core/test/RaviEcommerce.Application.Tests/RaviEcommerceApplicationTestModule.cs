using Volo.Abp.Modularity;

namespace RaviEcommerce;

[DependsOn(
    typeof(RaviEcommerceApplicationModule),
    typeof(RaviEcommerceDomainTestModule)
    )]
public class RaviEcommerceApplicationTestModule : AbpModule
{

}
