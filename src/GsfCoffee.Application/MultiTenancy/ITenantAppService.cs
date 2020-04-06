using Abp.Application.Services;
using GsfCoffee.MultiTenancy.Dto;

namespace GsfCoffee.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

