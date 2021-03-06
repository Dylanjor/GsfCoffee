﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using GsfCoffee.CoffeeUser;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsfCoffee.Coffee
{
    /// <summary>
    /// 用户类
    /// </summary>
    public class GsfInitAppService : GsfCoffeeAppServiceBase, IGsfInitAppService
    {
        private readonly IRepository<UserTable> _repository;

        Task IGsfInitAppService.Register { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Task<ListResultDto<UserTable>> IGsfInitAppService.Login { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        /// <summary>
        /// 注入
        /// </summary>
        /// <param name="repository"></param>
        public GsfInitAppService(IRepository<UserTable> repository) {
            _repository = repository;
        }
        /// <summary>
        /// 用户注册信息
        /// </summary>
        [HttpPost]
        public int Register(UserTable _userTable)
        {
            var ustb = ObjectMapper.Map<UserTable>(_userTable);
            int id = _repository.InsertAndGetId(ustb);
            return id;
        }
        /// <summary>
        /// 查询信息 登录
        /// </summary>
        /// <param name="userid">用户名</param>
        /// <param name="pwd">用户密码</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ListResultDto<UserTable>> Login(string Num, string pwd)
        {
            var usertable = await _repository
                .GetAll()
                .Where(c => c.Numbering == int.Parse(Num) && c.PassWord == pwd || c.Tel == Num && c.PassWord == pwd)
                .ToListAsync();
            return new ListResultDto<UserTable>(ObjectMapper.Map<List<UserTable>>(usertable));
        }
        /// <summary>
        /// 修改之前的获取数据
        /// </summary>
        /// <param name="Num"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ListResultDto<UserTable>> UpdateLogin(string Num)
        {
            var usertable = await _repository
                .GetAll()
                .Where(c => c.Numbering == int.Parse(Num))
                .ToListAsync();
            return new ListResultDto<UserTable>(ObjectMapper.Map<List<UserTable>>(usertable));
        }
        /// <summary>
        /// 用id取编码Numbering
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<int?> GetByid(int id)
        {
            var usertable = await _repository
                .GetAll()
                .Where(c => c.Id == id)
                .ToListAsync();
            return new ListResultDto<UserTable>(ObjectMapper.Map<List<UserTable>>(usertable)).Items[0].Numbering;
        }
        /// <summary>
        /// 查询所有的信息 
        /// 是否是vip 默认为是 
        /// 是否弃用 默认是否
        /// </summary>
        /// <param name="Delivery">是否是vip 默认为是</param>
        /// <param name="Deprecated">是否弃用 默认是否</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ListResultDto<UserTable>> GetAllasync(bool Delivery = true, bool Deprecated = false) {
            var usertable = await _repository
                .GetAll()
                .Where(c => c.Delivery == Delivery && c.Deprecated == Deprecated)
                .ToListAsync();
            return new ListResultDto<UserTable>(ObjectMapper.Map<List<UserTable>>(usertable));
        }
        /// <summary>
        /// 修改账户信息
        /// </summary>
        /// <param name="_userTable"></param>
        [HttpPost]
        public async Task<string> Updateasync(UserTable _userTable) {

            try
            {
                if (_userTable != null)
                {
                    var usertable = _repository
                                            .GetAll()
                                            .Where(c => c.Id == _userTable.Id)
                                            .AsNoTracking()
                                            .FirstOrDefault();
                    _userTable.CreateTime = usertable.CreateTime;
                    var task = ObjectMapper.Map<UserTable>(_userTable);
                    await _repository.UpdateAsync(task);
                }
            }
            catch(Exception error){
                return error.ToString();
            }
            return ("success");
        }
        /// <summary>
        /// 删除此用户（根据id）
        /// </summary>
        /// <param name="id"></param>
        [HttpGet]
        public async void Delete(int id) {
            await _repository.DeleteAsync(id);
        }
    }
}
