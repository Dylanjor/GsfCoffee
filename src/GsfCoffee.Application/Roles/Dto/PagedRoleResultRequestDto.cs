using Abp.Application.Services.Dto;

namespace GsfCoffee.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

