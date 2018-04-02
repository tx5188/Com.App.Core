using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
namespace Com.App.Model.Base
{
    public class BaseCompany:Entity
    {
      //  public int Id { get; set; } 
        /// <summary>
        /// 公司名称
        /// </summary>
        /// <returns></returns> 
        [Required]
        [StringLength(50)]
        public string CompanyName { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        /// <returns></returns>
        public string Phone { get; set; }
        
        /// <summary>
        /// 公司编号
        /// </summary>
        /// <returns></returns>
        public string CompanyCode { get; set; }
        /// <summary>
        /// 联系地址
        /// </summary>
        /// <returns></returns>
        public string Address { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        /// <returns></returns>
        public string Contacts { get; set; }
        public int DeleteFlag { get; set; }
    }
}