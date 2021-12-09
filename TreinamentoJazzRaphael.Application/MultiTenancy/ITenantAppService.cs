using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TreinamentoJazzRaphael.MultiTenancy.Dto;

namespace TreinamentoJazzRaphael.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
