using Com.App.Common;
using Com.App.Data.EntityFramework;
using Com.App.Data.Repository;
using Com.App.Model.Sys;
using Com.App.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.App.IBll.Sys
{
    public  interface IBll_SysUser
    { 
        List<SysUser> GetList();
        SysUser GetUserById(int userid);
        /// <summary>
        /// 根据用户名和密码查询用户信息
        /// </summary>
        /// <param name="userno"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Model.Sys.SysUser GetUserByLogin(string userno, string password); 
        /// <summary>
        /// 根据部门信息分页查询该部门下所有人员
        /// </summary>
        /// <param name="param"></param>
        /// <param name="dept"></param>
        /// <returns></returns>
        TableData getSysUserList(Param param,Model.Base.BaseDeparment dept);
        TableData SaveUser(SysMenu param);
        TableData UpdaUser(SysMenu param);
        TableData DelUser(SysMenu param);
    }
}
