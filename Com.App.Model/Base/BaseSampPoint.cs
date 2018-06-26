using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.App.Model.Base
{

    /// <summary>
    /// 采样点管理
    /// </summary>
    [Table("BASE_SAMPPOINT")]
    public class BaseSampPoint : Entity
    {
        /// <summary>
        /// 采样点名称
        /// </summary>
        public string SampPointName { get; set; }
        /// <summary>
        /// 采样点编号
        /// </summary>
        public string SampPointCode { get; set; }
        public string Memo { get; set; }
        public int DeleteFlag { get; set; }
        /// <summary>
        /// 新增人
        /// </summary>
        public string RecordMan { get; set; }
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime? RecordDate { get; set; }
        /// <summary>
        /// 更新人
        /// </summary>
        public string UpdateMan { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
        public string CheckMan { get; set; }
        /// <summary>
        /// 审核日期
        /// </summary>
        public DateTime? CheckDate { get; set; }
    }
}
