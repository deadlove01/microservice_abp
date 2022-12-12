using RaviEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RaviEcommerce.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class RaviEcommerceController : AbpControllerBase
{
    protected RaviEcommerceController()
    {
        LocalizationResource = typeof(RaviEcommerceResource);
    }
}
