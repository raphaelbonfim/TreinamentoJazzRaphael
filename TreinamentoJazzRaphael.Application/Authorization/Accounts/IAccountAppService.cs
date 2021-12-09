using System.Threading.Tasks;
using Abp.Application.Services;
using TreinamentoJazzRaphael.Authorization.Accounts.Dto;

namespace TreinamentoJazzRaphael.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
