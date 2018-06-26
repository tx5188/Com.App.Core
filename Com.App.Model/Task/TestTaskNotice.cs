using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.App.Model.Task
{
    /// <summary>
    /// 现场测试任务通知单
    /// </summary>
    [Table("TASK_TESTNOTICE")]
    public class TestTaskNotice : Entity
    {
        /// <summary>
        /// 送样部门ID
        /// </summary>
        public int DeptId { get; set; }
        [NotMapped]
        public string DeptName{ get; set; }
        /// <summary>
        /// 采样时间
        /// </summary>
        public DateTime SampDate { get; set; }
        /// <summary>
        /// 样品类别id(水质采样类别管理)
        /// </summary>
        public DateTime SampleTypeId { get; set; }
        [NotMapped]
        public string SampleTypeName { get; set; }
        /// <summary>
        /// <summary>
        /// 备注
        /// </summary>
        public String Memo { get; set; }
        /// <summary>
        /// 状态 0-新增 1-已提交 2-已审核 3-已驳回
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 创建人（技术质量负责人）
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
