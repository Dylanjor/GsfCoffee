using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GsfCoffee.OrderTable
{
    [Table("CommodityTable")]
    /// <summary>
    /// 商品表
    /// </summary>
    public class CommodityTable : Abp.Domain.Entities.Entity
    {
        /// <summary>
        /// 重写id
        /// </summary>
        public override int Id { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string CommodityName { get; set; }
        /// <summary>
        /// 商品图片 
        /// </summary>
        public string CommImage { get; set; }
        /// <summary>
        /// 商品规格
        /// </summary>
        public string Specification { get; set; }
        /// <summary>
        /// 商品类型
        /// </summary>
        public string CommodityType { get; set; }
        /// <summary>
        /// 是否是物料 不是物料就是成品
        /// </summary>
        public bool IsBom { get; set; }
        /// <summary>
        /// 进价
        /// </summary>
        public int? PurchasePrice { get; set; }
        /// <summary>
        /// BOM现有数量
        /// </summary>
        public int? Qty { get; set; }
        /// <summary>
        /// 售价
        /// </summary>
        public int? SellingPrice { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? DeletDateTime { get; set; }
    }
}
