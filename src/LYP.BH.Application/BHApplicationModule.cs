using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LYP.BH.Authorization;

namespace LYP.BH
{
    [DependsOn(
        typeof(BHCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BHApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BHAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BHApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
