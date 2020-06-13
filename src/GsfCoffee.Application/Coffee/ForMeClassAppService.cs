using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using GsfCoffee.ForME;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsfCoffee.Coffee
{
    public class ForMeClassAppService: GsfCoffeeAppServiceBase,IForMeClassAppService
    {
        private readonly IRepository<DiaryType> _repository;           //类别
        private readonly IRepository<DiaryComment> _repositoryComment; //评论
        private readonly IRepository<DiaryContent> _repositoryContent; //内容
        public ForMeClassAppService(IRepository<DiaryType> repository,
                                    IRepository<DiaryComment> repositoryComment,
                                    IRepository<DiaryContent> repositoryContent)
        {
            _repository        = repository;
            _repositoryComment = repositoryComment;
            _repositoryContent = repositoryContent;
        }
        /// <summary>
        /// 获取所有的日记类型
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ListResultDto<DiaryType>> GetAll() {
            var DiaryType = await _repository.GetAllListAsync();
            return new ListResultDto<DiaryType>(ObjectMapper.Map<List<DiaryType>>(DiaryType));
        }
        /// <summary>
        /// 添加创作日记
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<string> InsertDiary(DiaryContent diaryContent)
        {
            try
            {
                await _repositoryContent.InsertAsync(diaryContent);
                return ("保存成功");
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }
        /// <summary>
        /// 获取所有的日记
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ListResultDto<DiaryContent>> GetAllDiary()
        {
            var DiaryContent = await _repositoryContent.GetAllListAsync();
            return new ListResultDto<DiaryContent>(ObjectMapper.Map<List<DiaryContent>>(DiaryContent));
        }
        /// <summary>
        /// 根据条件
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ListResultDto<DiaryContent>> GetDiaryByTypeId(int Type)
        {
            var DiaryContent = await _repositoryContent.GetAll()
                            .Where(c=>c.DiaryType == Type)
                            .ToListAsync();
            return new ListResultDto<DiaryContent>(ObjectMapper.Map<List<DiaryContent>>(DiaryContent));
        }
    }
}
