using Abp.Application.Services;
using LYP.BH.MultiTenancy.Dto;

namespace LYP.BH.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

