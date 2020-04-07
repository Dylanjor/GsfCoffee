﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using GsfCoffee.CoffeeUser;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsfCoffee.Coffee
{
    public class GsfInitAppService : GsfCoffeeAppServiceBase, IGsfInitAppService
    {
        private readonly IRepository<UserTable> _repository;

        Task IGsfInitAppService.Register { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Task<ListResultDto<UserTable>> IGsfInitAppService.Login { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public GsfInitAppService(IRepository<UserTable> repository) {
            _repository = repository;
        }
        [HttpPost]
        /// <summary>
        /// 注册信息
        /// </summary>
        public async Task Register(UserTable _userTable)
        {
            var usertable = ObjectMapper.Map<UserTable>(_userTable);
            await _repository.InsertAsync(usertable);
        }
        /// <summary>
        /// 查询信息 登录
        /// </summary>
        /// <param name="userid">用户名</param>
        /// <param name="pwd">用户密码</param>
        /// <returns></returns>
        public async Task<ListResultDto<UserTable>> Login(string userid,string pwd)
        {
            var usertable = _repository
                .GetAll()
                .Where(c=>c.Name == userid && c.PassWord == pwd);
            return new ListResultDto<UserTable>(ObjectMapper.Map<List<UserTable>>(usertable));
        }
    }
}
