using System.Threading.Tasks;
using Abp.Application.Services;
using LYP.BH.Authorization.Accounts.Dto;

namespace LYP.BH.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
