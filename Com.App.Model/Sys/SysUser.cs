using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Com.App.Model.Base;
namespace Com.App.Model.Sys {
     
    public class SysUser :Entity 
    {
       // public int Id { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary>
        /// <returns></returns>
        public int DeptId { get; set; }

        /// <summary>
        /// 账号（登录用）
        /// </summary>
        /// <returns></returns> 
        [Required]
        public string UserNo { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        /// <returns></returns>
        [Required]
        [StringLength (50, ErrorMessage = "姓名不能为空")]
        public string UserName { get; set; }
        public string Password { get; set; }
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

        [ForeignKey ("DeptId")]
        public virtual  BaseDeparment BaseDeparment { get; set; }
        //public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}