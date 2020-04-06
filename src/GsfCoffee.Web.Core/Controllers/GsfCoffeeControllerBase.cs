using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GsfCoffee.Controllers
{
    public abstract class GsfCoffeeControllerBase: AbpController
    {
        protected GsfCoffeeControllerBase()
        {
            LocalizationSourceName = GsfCoffeeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
