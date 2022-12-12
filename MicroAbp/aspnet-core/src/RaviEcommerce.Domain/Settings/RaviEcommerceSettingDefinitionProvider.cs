using Volo.Abp.Settings;

namespace RaviEcommerce.Settings;

public class RaviEcommerceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(RaviEcommerceSettings.MySetting1));
    }
}
