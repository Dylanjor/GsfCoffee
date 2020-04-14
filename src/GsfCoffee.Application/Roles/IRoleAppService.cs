using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GsfCoffee.Roles.Dto;

namespace GsfCoffee.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedRoleResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> Rol_GetAllPermissions();

        Task<GetRoleForEditOutput> Rol_GetRoleForEdit(EntityDto input);

        Task<ListResultDto<RoleListDto>> Rol_GetRolesAsync(GetRolesInput input);
    }
}
