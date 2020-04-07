using Abp.Application.Services;
using Abp.Domain.Repositories;
using GsfCoffee.CoffeeUser;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GsfCoffee.Coffee
{
    public class GsfInitAppService: GsfCoffeeAppServiceBase,IGsfInitAppService
    {
        private readonly IRepository<UserTable> _repository;
        public GsfInitAppService(IRepository<UserTable> repository) {
            _repository = repository;
        }

        int IGsfInitAppService.Main { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [HttpPost]
        /// <summary>
        /// 注册信息
        /// </summary>
        public async Task Register(UserTable _userTable)
        {
            var usertable = ObjectMapper.Map<UserTable>(_userTable);
            await _repository.InsertAsync(usertable);
        }
    }
}
