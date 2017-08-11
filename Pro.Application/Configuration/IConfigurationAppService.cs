using System.Threading.Tasks;
using Abp.Application.Services;
using Pro.Configuration.Dto;

namespace Pro.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}