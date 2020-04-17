using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GsfCoffee.OrderTable
{
    [Table("ReturnTable")]
    /// <summary>
    /// 退货单
    /// </summary>
    public class ReturnTable : Abp.Domain.Entities.Entity
    {
        /// <summary>
        /// 重写id
        /// </summary>
        public override int Id { get; set; }
        /// <summary>
        /// 创建人ID
        /// </summary>
        public int FounderId { get; set; }
        /// <summary>
        /// 订单id
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// 总数量
        /// </summary>
        public int Qty { get; set; }
        /// <summary>
        /// 总价格
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
