using System;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Abp.Authorization;
using Abp.Domain.Services;
using Abp.Runtime.Session;
using GsfCoffee.Configuration.Dto;
using Microsoft.AspNetCore.Mvc;

namespace GsfCoffee.Configuration
{
    [AbpAuthorize]
     class ConfigurationAppService : GsfCoffeeAppServiceBase, IConfigurationAppService
    {

        [HttpPost]
        public async Task Con_ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
