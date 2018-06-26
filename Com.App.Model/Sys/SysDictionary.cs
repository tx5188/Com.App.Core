using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.App.Model.Sys
{
    /// <summary>
    /// 数据字典
    /// </summary>
    [Table("SYS_DICTIONARY")]
    public class SysDictionary : Entity
    {
      /// <summary>
      /// 参数类型
      /// </summary>
        public string DicType { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        public string DicCode { get; set; }
        /// <summary>
        /// 参数名称
        /// </summary>
        public string DicName { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int DicOrder { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string DicMemo{ get; set; }
        /// <summary>
        /// 删除标志 0 正常 1删除
        /// </summary>
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
    }
}
