using System;
using System.Collections.Generic;
using System.Text;

namespace GsfCoffee.ForME
{
    public class DiaryType: Abp.Domain.Entities.Entity
    {
        /// <summary>
        /// 唯一值
        /// </summary>
        public override int Id { get; set; }
        /// <summary>
        /// 类别名称
        /// </summary>
        public string TypeName { get; set; }
    }
}
