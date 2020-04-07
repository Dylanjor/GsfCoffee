using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GsfCoffee.CoffeeUser;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GsfCoffee.Coffee
{
    public interface IGsfInitAppService: IApplicationService
    {
        /// <summary>
        /// 注册的接口
        /// </summary>
        Task Register { get; set; }
        /// <summary>
        /// 登陆的接口
        /// </summary>
        Task<ListResultDto<UserTable>> Login { get; set; }
    }
}
