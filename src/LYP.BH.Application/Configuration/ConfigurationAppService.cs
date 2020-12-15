using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LYP.BH.Configuration.Dto;

namespace LYP.BH.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BHAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
