using System.Threading.Tasks;
using Abp.Application.Services;
using GsfCoffee.Authorization.Accounts.Dto;

namespace GsfCoffee.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> Acc_IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Acc_Register(RegisterInput input);
    }
}
