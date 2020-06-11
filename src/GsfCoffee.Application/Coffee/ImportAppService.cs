using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using GsfCoffee.ImportOut;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GsfCoffee.Coffee
{
    public class ImportAppService : GsfCoffeeAppServiceBase, IImportAppService
    {
        private readonly IRepository<ImportPlan> _repository;
        public ImportAppService(IRepository<ImportPlan> repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="importPlan"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<string> Insert(ImportPlan[] importPlan) {
            try
            {
                foreach (var item in importPlan)
                {
                    var ustb = ObjectMapper.Map<ImportPlan>(item);
                    await _repository.InsertAsync(ustb);
                }
                return "导入成功";
            }
            catch (Exception e) {
                return e.ToString();
            }
        }
        /// <summary>
        /// 获取所有的数据
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ListResultDto<ImportPlan>> GetAll()
        {
            var importPlan = await _repository.GetAllListAsync();
            return new ListResultDto<ImportPlan>(ObjectMapper.Map<List<ImportPlan>>(importPlan));
        }
    }
}
