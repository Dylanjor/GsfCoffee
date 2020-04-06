using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GsfCoffee.Configuration;

namespace GsfCoffee.Web.Host.Startup
{
    [DependsOn(
       typeof(GsfCoffeeWebCoreModule))]
    public class GsfCoffeeWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GsfCoffeeWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GsfCoffeeWebHostModule).GetAssembly());
        }
    }
}
