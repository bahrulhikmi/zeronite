using Volo.Abp.Settings;

namespace Zeronite.Infra.Settings
{
    public class InfraSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(InfraSettings.MySetting1));
        }
    }
}
