using System;
using System.Collections.Generic;
using System.Text;

namespace GsfCoffee.ImportOut
{
    public class ImportPlan: Abp.Domain.Entities.Entity
    {
        /// <summary>
        /// 唯一标识列
        /// </summary>
        public override int Id { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Datetime { get; set; }
        /// <summary>
        /// 班次
        /// </summary>
        public string Shift { get; set; }
        /// <summary>
        /// 值班
        /// </summary>
        public string Onduty { get; set; }
        /// <summary>
        /// 场地
        /// </summary>
        public string Site { get; set; }
        /// <summary>
        /// 船名
        /// </summary>
        public string Shipname { get; set; }
        /// <summary>
        /// 货主
        /// </summary>
        public string Consignor { get; set; }
        /// <summary>
        /// 作业类型
        /// </summary>
        public string Jobtype { get; set; }
        /// <summary>
        /// 班组
        /// </summary>
        public string Team { get; set; }
        /// <summary>
        /// 作业量
        /// </summary>
        public string Workload { get; set; }
        /// <summary>
        /// 计划量
        /// </summary>
        public string PlanQty { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }
    }
}
