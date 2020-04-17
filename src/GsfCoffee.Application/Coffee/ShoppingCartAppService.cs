using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using GsfCoffee.CoffeeUser;
using GsfCoffee.OrderTable;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsfCoffee.Coffee
{
    public class ShoppingCartAppService : GsfCoffeeAppServiceBase, IShoppingCartAppService
    {
        /// <summary>
        /// 接口注入
        /// </summary>
        private readonly IRepository<ShoppingCartTable> _repositoryShop;    //购物车表
        private readonly IRepository<CommodityTable> _repositoryComm;       //商品表
        private readonly IRepository<UserTable> _repositoryUser;            //用户表
        public ShoppingCartAppService(IRepository<ShoppingCartTable> repositoryShop,
            IRepository<CommodityTable> repositoryComm,
            IRepository<UserTable> repositoryUser)
        {
            _repositoryShop = repositoryShop;
            _repositoryComm = repositoryComm;
            _repositoryUser = repositoryUser;
        }
        /// <summary>
        /// GetShoppingByuserId 获取当前用户下的所有购物车内容
        /// </summary>
        /// <param name="UserId">用户的Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ListResultDto<ShoppingCartTable>> GetShoppingByUserId(int _UserId) {
            var Shoppingtable = await _repositoryShop.GetAll()
                .Where(c => c.FounderId == _UserId)
                .ToListAsync();
            return new ListResultDto<ShoppingCartTable>(ObjectMapper.Map<List<ShoppingCartTable>>(Shoppingtable));
        }
        /// <summary>
        /// 创建OR修改购物车商品的数量
        /// </summary>
        /// <param name="Qty"></param>
        /// <param name="Id"></param>
        [HttpPost]
        public  void UpdateShoppingQty(ShoppingCartTable _shoppingCartTable) {
            try {
                var Shoppingtable =  _repositoryShop.GetAll()
                    .Where(c => c.Id == _shoppingCartTable.Id)
                    .ToList();
                // 如果购物车中没有此id就创建
                if (Shoppingtable.Count == 0)
                {
                     _repositoryShop.Insert(_shoppingCartTable);
                }
                else {
                    //如果数量等于0就将其删掉
                    if (_shoppingCartTable.Qty == 0)
                    {
                         _repositoryShop.Delete(_shoppingCartTable);
                    }
                    else
                    {
                         _repositoryShop.Update(_shoppingCartTable);
                    }
                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// 删除购物车
        /// </summary>
        /// <param name="_shoppingCartTable"></param>
        [HttpPost]
        public async void DeleShopping(ShoppingCartTable _shoppingCartTable) {
            try
            {

            }
            catch { 
            
            }
        }
    }
}
