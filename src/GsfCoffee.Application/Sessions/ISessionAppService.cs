using System.Threading.Tasks;
using Abp.Application.Services;
using GsfCoffee.Sessions.Dto;

namespace GsfCoffee.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
