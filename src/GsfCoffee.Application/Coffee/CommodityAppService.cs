using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
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
    /// <summary>
    /// 商品类
    /// </summary>
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
        public async void InsertComm(CommodityTable commodityTable)
        {
            await _repositoryComm.InsertAsync(commodityTable);
        }
        /// <summary>
        /// 获取商品具体信息通过商品的ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ListResultDto<CommodityTable>> GetCommByCommId(int Id)
        {
            var commodity = await _repositoryComm.GetAll()
                .Where(c => c.Id == Id)
                .ToListAsync();
            return new ListResultDto<CommodityTable>(ObjectMapper.Map<List<CommodityTable>>(commodity));
        }
        /// <summary>
        /// 修改商品信息 返回全部的商品信息
        /// </summary>
        /// <param name="commodityTable"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ListResultDto<CommodityTable>> UpdateComm(CommodityTable commodityTable) {
            await _repositoryComm.UpdateAsync(commodityTable);
            var commodity = _repositoryComm.GetAll()
                .ToListAsync();
            return new ListResultDto<CommodityTable>(ObjectMapper.Map<List<CommodityTable>>(commodity));
        }
        /// <summary>
        /// 删除商品（根据商品id）
        /// </summary>
        /// <param name="CommId">商品id</param>
        [HttpGet]
        public async void DeleteComm(int CommId) {
           await _repositoryComm.DeleteAsync(CommId);
        }
        /// <summary>
        /// 查询商品（跟据商品类型id）
        /// </summary>
        /// <param name="ProdSpec">商品类型id</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ListResultDto<CommodityTable>> GetAllComm(int ProdSpec)
        {
            var commodity = await _repositoryComm.GetAll()
                .Where(c=>c.CommodityTypeId == ProdSpec)
                .ToListAsync();
            return new ListResultDto<CommodityTable>(ObjectMapper.Map<List<CommodityTable>>(commodity));
        }
    }
}
