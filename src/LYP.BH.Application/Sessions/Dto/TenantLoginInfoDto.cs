using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LYP.BH.MultiTenancy;

namespace LYP.BH.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
