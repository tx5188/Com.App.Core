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
    public interface IBll_SysMenu  
    {
        List<SysMenu> GetListMenu(string parentid);
        List<SysMenu> GetListAll();
        SysMenu GetMenuById(int id);
        TableData getSysMenuList(Param param);
        TableData SaveMenu(SysMenu param);
        TableData UpdaMenu(SysMenu param);
        TableData DelMenu(SysMenu param);
    }
}
