using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GsfCoffee.CoffeeUser
{
    [Table("UserTable")]
    public class UserTable: Abp.Domain.Entities.Entity
    {
        /// <summary>
        /// 重写id
        /// </summary>
        public override int Id { get; set; }
        /// <summary>
        /// 账户姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 账户密码
        /// </summary>
        public string PassWord { get;set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Resource { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 店面
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// 是否是vip
        /// </summary>
        public bool Delivery { get; set; }
        /// <summary>
        /// 爱好
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 是否弃用
        /// </summary>
        public bool Deprecated { get; set; }
        /// <summary>
        /// 弃用时间
        /// </summary>
        public DateTime? DeprecatedTime { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 不重复编号
        /// </summary>
        public int? Numbering { get; set; }
    }
}
