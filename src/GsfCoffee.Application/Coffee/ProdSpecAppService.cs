using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
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
    /// 商品类型类
    /// </summary>
    public class ProdSpecAppService : GsfCoffeeAppServiceBase, IProdSpecAppService
    {
        private readonly IRepository<ProductSpecificationsTable> _repositoryProd;
        private readonly IRepository<CommodityTable> _repositoryComm;
        public ProdSpecAppService(IRepository<ProductSpecificationsTable> repositoryProd,
                                  IRepository<CommodityTable> repositoryComm) {
            _repositoryProd = repositoryProd;
            _repositoryComm = repositoryComm;
        }
        [HttpGet]
        /// <summary>
        /// 跟据typeId查询typename
        /// </summary>
        /// <param name="TypeId"></param>
        /// <returns></returns>
        public async Task<ListResultDto<ProductSpecificationsTable>> GetByTypeId(int TypeId) {
            var ProdSpec = await _repositoryProd.GetAll()
                .Where(c => c.Id == TypeId)
                .ToListAsync();
            return new ListResultDto<ProductSpecificationsTable>(ObjectMapper.Map<List<ProductSpecificationsTable>>(ProdSpec));
        }
        [HttpPost]
        /// <summary>
        /// 添加商品类型信息
        /// </summary>
        /// <param name="prodspec"></param>
        /// <returns></returns>
        public async void InsertProdspec(ProductSpecificationsTable prodspec) {
            try { await _repositoryProd.InsertAsync(prodspec); }
            catch { }
        }
        [HttpPost]
        /// <summary>
        /// 修改商品类型信息
        /// </summary>
        /// <param name="prodspec"></param>
        /// <returns></returns>
        public async void UpdateProdspec(ProductSpecificationsTable prodspec) {
            await _repositoryProd.UpdateAsync(prodspec);
        }
        [HttpPost]
        /// <summary>
        /// 所有的商品类型
        /// </summary>
        /// <param name="TypeId"></param>
        /// <returns></returns>
        public async Task<ListResultDto<ProductSpecificationsTable>> GetAllList()
        {
            var ProdSpec = await _repositoryProd.GetAll()
                .ToListAsync();
            return new ListResultDto<ProductSpecificationsTable>(ObjectMapper.Map<List<ProductSpecificationsTable>>(ProdSpec));
        }
    }
}
