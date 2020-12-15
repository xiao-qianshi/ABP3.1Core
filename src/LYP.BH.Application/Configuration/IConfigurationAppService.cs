using System.Threading.Tasks;
using LYP.BH.Configuration.Dto;

namespace LYP.BH.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
