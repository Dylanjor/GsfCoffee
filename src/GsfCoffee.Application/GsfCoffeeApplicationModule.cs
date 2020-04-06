using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GsfCoffee.Authorization;

namespace GsfCoffee
{
    [DependsOn(
        typeof(GsfCoffeeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GsfCoffeeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GsfCoffeeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GsfCoffeeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
