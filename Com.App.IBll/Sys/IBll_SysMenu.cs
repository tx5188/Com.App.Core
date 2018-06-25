using Com.App.Data.EntityFramework;
using Com.App.Data.Repository;
using Com.App.Model.Sys;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.App.IBll.Sys
{
    public interface IBll_SysMenu  
    {
        List<SysMenu> GetListMenu();
    }
}
