using System;
using System.Collections.Generic;
using System.Text;

namespace GsfCoffee.ForME
{
    /// <summary>
    /// 日记内容
    /// </summary>
    public class DiaryContent : Abp.Domain.Entities.Entity
    {
        public override int Id { get; set; }
        /// <summary>
        /// 日记内容
        /// </summary>
        public string Diarycontent { get; set; }
        /// <summary>
        /// 日记类别
        /// </summary>
        public int DiaryType { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 天气
        /// </summary>
        public string Weather { get; set; }
        /// <summary>
        /// 提交人
        /// </summary>
        public string Person { get; set; }
        /// <summary>
        /// 心情
        /// </summary>
        public string Mood { get; set; }
        /// <summary>
        /// 提交日期时间
        /// </summary>
        public DateTime DateTime { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
    }
}
