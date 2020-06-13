using System;
using System.Collections.Generic;
using System.Text;

namespace GsfCoffee.ForME
{
    public class DiaryComment:Abp.Domain.Entities.Entity
    {
        public override int Id { get; set; }
        /// <summary>
        /// 评论人
        /// </summary>
        public string Person { get; set; }
        /// <summary>
        /// 日记ID
        /// </summary>
        public int ContentId { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Diarycomment { get; set; }
        /// <summary>
        /// 评论日期
        /// </summary>
        public DateTime DateTime { get; set; }
    }
}
