using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Com.App.Web.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "用户名不能为空。")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "密码不能为空。")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        /// <summary>
        /// 是否管理员
        /// </summary>
        public int isAdmin { get; set; }
        
        public Model.Sys.SysUser user { get; set; }
    }
}
