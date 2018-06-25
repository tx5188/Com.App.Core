using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Com.App.Model.Task
{
    /// <summary>
    /// 采样计划表明细
    /// </summary>
    [Table("TASK_SAMPLINPLAN_DETAIL")]
    public class SamplingPlanDetail : Entity
    {
        /// <summary>
        /// 采样计划id
        /// </summary>
        public int  SampId { get; set; }
        /// <summary>
        /// 分组
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// 采样人员(存人员id号 逗号分隔)
        /// </summary>
        public string  SamplingMan { get; set; }
        /// <summary>
        /// 交通工具（字典选择）
        /// </summary>
        public string Vehicle { get; set; }
        /// <summary>
        /// 携带设备
        /// </summary>
        public string Equipment { get; set; } 
        /// <summary>
        /// 采样点id
        /// </summary>
        public int PointId { get; set; } 
        /// <summary>
        /// 出发时间
        /// </summary>
        public DateTime LeaveTime { get; set; } 
        /// <summary>
        /// 返回上交时间（16：30前送达实验室）
        /// </summary>
        public DateTime BackTime { get; set; } 
        /// <summary>
        /// 备注
        /// </summary>
        public String Memo { get; set; }
    }
}

