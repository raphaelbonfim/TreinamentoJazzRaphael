using Abp.AutoMapper;
using TreinamentoJazzRaphael.Sessions.Dto;

namespace TreinamentoJazzRaphael.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}