using System.Threading.Tasks;
using Abp.Application.Services;
using Pro.Authorization.Accounts.Dto;

namespace Pro.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
