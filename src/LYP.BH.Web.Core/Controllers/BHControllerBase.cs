using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LYP.BH.Controllers
{
    public abstract class BHControllerBase: AbpController
    {
        protected BHControllerBase()
        {
            LocalizationSourceName = BHConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
