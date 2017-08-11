using System.Threading.Tasks;
using Abp.Application.Services;
using Pro.Sessions.Dto;

namespace Pro.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
