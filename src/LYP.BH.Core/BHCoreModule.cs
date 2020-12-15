using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using LYP.BH.Authorization.Roles;
using LYP.BH.Authorization.Users;
using LYP.BH.Configuration;
using LYP.BH.Localization;
using LYP.BH.MultiTenancy;
using LYP.BH.Timing;

namespace LYP.BH
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class BHCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            BHLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = BHConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
            
            Configuration.Localization.Languages.Add(new LanguageInfo("fa", "فارسی", "famfamfam-flags ir"));
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BHCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
