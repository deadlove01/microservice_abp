using System;
using System.Collections.Generic;
using System.Text;
using RaviEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace RaviEcommerce;

/* Inherit your application services from this class.
 */
public abstract class RaviEcommerceAppService : ApplicationService
{
    protected RaviEcommerceAppService()
    {
        LocalizationResource = typeof(RaviEcommerceResource);
    }
}
