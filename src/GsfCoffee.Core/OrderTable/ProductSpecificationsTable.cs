using System;
using System.Collections.Generic;
using System.Text;

namespace GsfCoffee.OrderTable
{
    public class ProductSpecificationsTable : Abp.Domain.Entities.Entity
    {
        /// <summary>
        /// 重写id
        /// </summary>
        public override int Id { get; set; } 
        /// <summary>
        /// 商品类型名称
        /// </summary>
        public string TypeName { get; set; }
    }
}
