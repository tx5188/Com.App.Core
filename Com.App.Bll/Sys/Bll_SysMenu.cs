using Com.App.Data.EntityFramework;
using Com.App.Data.Repository;
using Com.App.IBll.Sys;
using Com.App.Model.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.App.Data;
using Com.App.Web.Models;
using Com.App.Common;

namespace Com.App.Bll.Sys
{
    public class Bll_SysMenu : BaseApp<MyDbContext, SysMenu, int>, IBll_SysMenu
    {
        private readonly MyDbContext context;

        public Bll_SysMenu(IDbContextProvider<MyDbContext> dbContextProvider)
             : base(dbContextProvider)
        {
            context = dbContextProvider.GetDbContext();
        }


        public List<SysMenu> GetListMenu(string parentid)
        {
            List<SysMenu> list = Repository.FindBy(p => p.ParentId.ToString() == parentid.Trim()&& p.DeleteFlag==0).OrderBy(p => p.MenuOrder).ToList();
            return list;
        }
        public List<SysMenu> GetListAll()
        {
            List<SysMenu> list = Repository.All.ToList();
            return list;
        }
        public  SysMenu  GetMenuById(int id)
        {
            SysMenu list = Repository.GetSingle(id);
            return list;
        }
        /// <summary>
        /// 菜单查询（分页）
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public TableData getSysMenuList(Param param)
        {
            List<SysMenu> list2 = new List<SysMenu>();
            List<SysMenu> list = new List<SysMenu>();
            // string sql = @"SELECT a.*,ISNULL((SELECT MenuName FROM dbo.SYS_MENU b WHERE b.ParentId=a.id)  AS ParentName,'无') FROM dbo.SYS_MENU a";
            list = UnitWork.Find(p=>p.DeleteFlag==0)
                   .OrderBy(u => u.MenuCode)
                   .Skip((param.page - 1) * param.limit)
                   .Take(param.limit).ToList();
            foreach (var temp in list)
            {
                SysMenu menu = UnitWork.FindSingle(o => o.Id == temp.ParentId);
                if (menu != null)
                {
                    temp.ParentName = menu.MenuName;
                }
                else
                {
                    temp.ParentName = "";
                }
                list2.Add(temp);
            }
            int count = UnitWork.GetCount(null);

            return new TableData
            {
                totalCount = count,
                result = list2

            };

        }

        public TableData SaveMenu(SysMenu param)
        {
            try
            {
                int mencodecount = UnitWork.GetCount(p => p.MenuCode == param.MenuCode && p.DeleteFlag == 0);
                int mennamecount = UnitWork.GetCount(p => p.MenuName == param.MenuName && p.DeleteFlag == 0);

                if (mencodecount > 0)
                {
                    return new TableData
                    {
                        msg = "菜单编码已存在",
                        code = 404
                    };
                }
                if (mennamecount > 0)
                {
                    return new TableData
                    {
                        msg = "菜单名称已存在",
                        code = 404
                    };
                }
                UnitWork.Add(param);
                UnitWork.Save();
                return new TableData
                {
                    msg = "success",
                    code = 200
                };
            }
            catch (Exception ex)
            {
                return new TableData
                {
                    msg = ex.Message,
                    code = 400
                };
            }
        }
        public TableData UpdaMenu(SysMenu param)
        {
            try
            {
                int mencodecount = UnitWork.GetCount(p => p.MenuCode == param.MenuCode && p.DeleteFlag == 0);
                int mennamecount = UnitWork.GetCount(p => p.MenuName == param.MenuName && p.DeleteFlag == 0);

                if (mencodecount >  0)
                {
                    SysMenu menu = UnitWork.FindSingle(p => p.Id == param.Id);
                    if (menu != null &&  param.MenuCode != menu.MenuCode)
                    {
                        return new TableData
                        {
                            msg = "菜单编码已存在",
                            code = 404
                        };
                    }
                }
                if (mennamecount > 0)
                {
                    SysMenu menu = UnitWork.FindSingle(p => p.Id == param.Id);
                    if (menu!=null && menu.MenuName!=param.MenuName)
                    {
                        return new TableData
                        {
                            msg = "菜单名称已存在",
                            code = 404
                        };
                    }

                }
                UnitWork.Update(param);
                UnitWork.Save();
                return new TableData
                {
                    msg = "success",
                    code = 200
                };
            }
            catch (Exception ex)
            {
                return new TableData
                {
                    msg = ex.Message,
                    code = 400
                };
            }
        }
        public TableData DelMenu(SysMenu param)
        {
            try
            {
                param.DeleteFlag = 1;
                UnitWork.Update(param);
                UnitWork.Save();
                return new TableData
                {
                    msg = "success",
                    code = 200
                };
            }
            catch (Exception ex)
            {
                return new TableData
                {
                    msg = ex.Message,
                    code = 400
                };
            }
        }
    }
}
