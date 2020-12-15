using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LYP.BH.EntityFrameworkCore;
using LYP.BH.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LYP.BH.Web.Tests
{
    [DependsOn(
        typeof(BHWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BHWebTestModule : AbpModule
    {
        public BHWebTestModule(BHEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BHWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BHWebMvcModule).Assembly);
        }
    }
}