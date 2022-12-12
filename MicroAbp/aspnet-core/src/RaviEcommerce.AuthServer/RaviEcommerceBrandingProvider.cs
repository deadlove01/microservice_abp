using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace RaviEcommerce;

[Dependency(ReplaceServices = true)]
public class RaviEcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "RaviEcommerce";
}
