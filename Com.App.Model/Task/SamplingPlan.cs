using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.App.Model.Task
{
    /// <summary>
    /// 采样计划表
    /// </summary>
    [Table("TASK_SAMPLINPLAN")]
    public class SamplingPlan : Entity
    {
        /// <summary>
        ///  部门ID
        /// </summary>
        public int DeptId { get; set; }
        [NotMapped]
        public string DeptName { get; set; }
        /// <summary>
        /// 任务来源
        /// </summary>
        public string TaskFrom { get; set; }
        /// <summary>
        /// 采样安排日期
        /// </summary>
        public DateTime PlanDate { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public String Memo { get; set; }
        /// <summary>
        /// 状态 0-新增 1-已提交 2-已审核 3-已驳回
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string RecordMan { get; set; }
        /// <summary>
        /// 创建日期
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

        /// <summary>
        /// 审核人
        /// </summary>
        public string CheckMan { get; set; }
        /// <summary>
        /// 审核日期
        /// </summary>
        public DateTime CheckDate { get; set; }


    }
}
