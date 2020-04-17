using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GsfCoffee.OrderTable
{
    [Table("OrderHeaderTable")]
    /// <summary>
    /// 订单头表
    /// </summary>
    public class OrderHeaderTable : Abp.Domain.Entities.Entity
    {
        /// <summary>
        /// 重写id
        /// </summary>
        public override int Id { get; set; }
        /// <summary>
        /// 总数量
        /// </summary>
        public int Qty { get; set; }
        /// <summary>
        /// 总价格
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// 创建人Id
        /// </summary>
        public int FounderId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 发货状态
        /// </summary>
        public bool DeliveryStatus { get; set; }
        /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime? DeliveryTime { get; set; }
        /// <summary>
        /// 付款状态
        /// </summary>
        public bool PaymentStatus { get; set; }
        /// <summary>
        /// 付款时间
        /// </summary>
        public DateTime? PaymentTime { get; set; }
        /// <summary>
        /// 是否已退单
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 退货时间
        /// </summary>
        public DateTime? DeletedTime { get; set; }
    }
}
