using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.App.Model.Base
{
    /// <summary>
    /// 水质类型管理
    /// </summary>
    [Table("BASE_WATERTYPE")]
    public class BaseWaterType:Entity
    {
        /// <summary>
        /// 采样点名称
        /// </summary>
        public string WaterTypeName { get; set; }
        /// <summary>
        /// 类型 1--水质分类 2-水质类型
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// 父节点
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int WaterTypeOrder { get; set; }
        public string Memo { get; set; }
        public int DeleteFlag { get; set; }
        /// <summary>
        /// 新增人
        /// </summary>
        public string RecordMan { get; set; }
        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime RecordDate { get; set; }
        /// <summary>
        /// 更新人
        /// </summary>
        public string UpdateMan { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}
