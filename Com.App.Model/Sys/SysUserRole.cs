using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
namespace Com.App.Model.Sys
{
    public class SysUserRole : Entity
    {
     //   public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
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
    }
}