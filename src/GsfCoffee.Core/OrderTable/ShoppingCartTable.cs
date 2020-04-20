using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GsfCoffee.OrderTable
{
    [Table("ShoppingCartTable")]
    /// <summary>
    /// 购物车表
    /// </summary>
    public class ShoppingCartTable : Abp.Domain.Entities.Entity
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
        public int TotalCost { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string Specification { get; set; }
        /// <summary>
        /// 单位价格
        /// </summary>
        public int UnitPrice { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 是否已经购买
        /// </summary>
        public bool IsBought { get; set; }
        /// <summary>
        /// 购买时间
        /// </summary>
        public DateTime? BoughtTime { get; set; }
        /// <summary>
        /// 创建人Id
        /// </summary>
        public int FounderId { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Desc { get; set; }
    }
}
