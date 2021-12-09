using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TreinamentoJazzRaphael.Configuration.Dto;

namespace TreinamentoJazzRaphael.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TreinamentoJazzRaphaelAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
