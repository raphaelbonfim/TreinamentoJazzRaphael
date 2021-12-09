using System.Threading.Tasks;
using Abp.Application.Services;
using TreinamentoJazzRaphael.Configuration.Dto;

namespace TreinamentoJazzRaphael.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}