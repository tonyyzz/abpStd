using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Pro.Configuration.Dto;

namespace Pro.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
