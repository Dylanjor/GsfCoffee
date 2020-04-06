using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GsfCoffee.Configuration.Dto;

namespace GsfCoffee.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GsfCoffeeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
