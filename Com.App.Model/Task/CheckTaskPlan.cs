using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.App.Model.Task
{
    /// <summary>
    /// 检查任务计划表
    /// </summary>
    [Table("TASK_TESTPLAN")]
    public class TaskTestPlan : Entity
    {
        /// <summary>
        ///  部门ID
        /// </summary>
        public int DeptId { get; set; }
        [NotMapped]
        public string DeptName { get; set; }
        /// <summary>
        /// 任务名称
        /// </summary>
        public string TaskName { get; set; }
        /// <summary>
        /// 任务编号(系统自动生成)
        /// </summary>
        public string TaskCode { get; set; }
        /// <summary>
        /// 状态 0-新增 1-已提交 2-已审核 3-已驳回
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 检测范围
        /// </summary>
        public string TestRange { get; set; }
        /// <summary>
        /// 检测目的
        /// </summary>
        public string TestObjective { get; set; }
        /// <summary>
        /// 检测依据(数据字典选择)
        /// </summary>
        public string TestBasis { get; set; }
        /// <summary>
        /// 质控措施（室内）(数据字典选择)
        /// </summary>
        public string QualityControleIn { get; set; }
        /// <summary>
        /// 质控措施（室外）(数据字典选择)
        /// </summary>
        public string QualityControleOut { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime BegDate { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 参与人（存id号，从人员管理中选择）
        /// </summary>
        public string Participants { get; set; } 
        /// <summary>
        /// 成果形式
        /// </summary>
        public string ResultsForm { get; set; }

        /// <summary>
        /// 技术负责人
        /// </summary>
        public string TechnicalLeader { get; set; }
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
        /// <summary>
        /// 备注
        /// </summary>
        public String Memo { get; set; }
    }
}
