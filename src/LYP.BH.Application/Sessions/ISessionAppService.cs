using System.Threading.Tasks;
using Abp.Application.Services;
using LYP.BH.Sessions.Dto;

namespace LYP.BH.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
