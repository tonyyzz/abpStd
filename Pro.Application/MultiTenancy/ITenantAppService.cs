using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Pro.MultiTenancy.Dto;

namespace Pro.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
