using Com.App.Common;
using Com.App.Model.Base;
using Com.App.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.App.IBll.Base
{
    public interface IBll_BaseDeptMent
    {

        /// <summary>
        /// 根据父节点id查询本节点和所有子节点
        /// </summary>
        /// <param name="parentid"></param>
        /// <returns></returns>
        List<BaseDeparment> GetListDept(string parentid);
        /// <summary>
        /// 查询所有部门
        /// </summary>
        /// <returns></returns>
        List<BaseDeparment> GetListAll();
        /// <summary>
        /// 根据id查询部门信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BaseDeparment GetDeptById(int id); 
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="param"></param>
        /// <param name="parentid"></param>
        /// <returns></returns>
        TableData GetBaseDeptList(Param param, string parentid);
        TableData SaveDept(BaseDeparment param);
        TableData UpdaDept(BaseDeparment param);
        TableData DelDept(BaseDeparment param);
    }
}
