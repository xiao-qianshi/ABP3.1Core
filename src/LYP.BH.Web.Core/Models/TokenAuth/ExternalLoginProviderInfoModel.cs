using Abp.AutoMapper;
using LYP.BH.Authentication.External;

namespace LYP.BH.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
