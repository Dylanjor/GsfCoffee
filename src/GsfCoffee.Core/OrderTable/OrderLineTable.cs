using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GsfCoffee.OrderTable
{
    [Table("OrderLineTable")]
    /// <summary>
    /// 订单行表
    /// </summary>
    public class OrderLineTable : Abp.Domain.Entities.Entity
    {
        /// <summary>
        /// 重写id
        /// </summary>
        public override int Id { get; set; }
        /// <summary>
        /// 商品的ID
        /// </summary>
        public int CommodityId { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Qty { get; set; }
        /// <summary>
        /// 总价格
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// 单位价格
        /// </summary>
        public int UnitPrice { get; set; }
        /// <summary>
        /// 订单ID
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// 创建人Id
        /// </summary>
        public int FounderId { get; set; }
    }
}
