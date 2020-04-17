using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using GsfCoffee.OrderTable;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GsfCoffee.Coffee
{
    public class CommodityAppService:GsfCoffeeAppServiceBase, ICommodityAppService
    {
        private readonly IRepository<CommodityTable> _repositoryComm;       //商品表
        public CommodityAppService(IRepository<CommodityTable> repositoryComm)
        {
            _repositoryComm = repositoryComm;
        }
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="commodityTable"></param>
        [HttpPost]
        public async void insertComm(CommodityTable commodityTable)
        {
            await _repositoryComm.InsertAsync(commodityTable);
        }
        /// <summary>
        /// 修改商品信息 返回全部的商品信息
        /// </summary>
        /// <param name="commodityTable"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ListResultDto<CommodityTable>> updateComm(CommodityTable commodityTable) {
            await _repositoryComm.UpdateAsync(commodityTable);
            var commodity = _repositoryComm.GetAll()
                .ToListAsync();
            return new ListResultDto<CommodityTable>(ObjectMapper.Map<List<CommodityTable>>(commodity));
        }
        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="CommId"></param>
        [HttpGet]
        public async void DeleteComm(int CommId) {
           await _repositoryComm.DeleteAsync(CommId);
        }
        /// <summary>
        /// 查询商品
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ListResultDto<CommodityTable>> GetAllComm()
        {
            var commodity = await _repositoryComm.GetAll()
                .ToListAsync();
            return new ListResultDto<CommodityTable>(ObjectMapper.Map<List<CommodityTable>>(commodity));
        }
    }
}
