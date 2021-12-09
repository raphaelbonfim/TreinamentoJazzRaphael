using System.Threading.Tasks;
using Abp.Application.Services;
using TreinamentoJazzRaphael.Sessions.Dto;

namespace TreinamentoJazzRaphael.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
