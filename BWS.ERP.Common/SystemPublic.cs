﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BWS.ERP.Common
{
    /// <summary>
    /// ERP系统公共开发包
    /// </summary>
    public class SystemPublic
    {
        #region 初始化LookUp查询

        /// <summary>
        /// 初始化LookUp控件
        /// </summary>
        /// <param name="lkp">LookUp控件</param>
        /// <param name="sql">查询SQL</param>
        /// <param name="returnfield">返回字段</param>
        /// <param name="displayfield">显示字段</param>
        /// <param name="columnfield">查询窗口Grid显示列</param>
        /// <param name="columntetx">查询窗口Grid列显示名称</param>
        /// <param name="text">查询窗体标题</param>
        public static void InitLookUpBase(BWS.ERP.Controls.BWSLookUp lkp, string sql, string returnfield, string displayfield, string columnfield, string columntetx, string text)
        {
            lkp.SearchFormText = text;
            lkp.SQL = sql;
            lkp.DataField = returnfield;
            lkp.DisplayField = displayfield;
            lkp.GridDisplayField = columnfield;
            lkp.GridColumnText = columntetx;
        }

        /// <summary>
        ///初始化员工查询 
        /// </summary>
        /// <param name="lkp">LookUp控件</param>
        public static void InitLkpSystemUser(BWS.ERP.Controls.BWSLookUp lkp)
        {
            InitLookUpBase(lkp, "SELECT ID,sUserID,sUserCName,sUserEName,sDeptNo,sDeptName,sRemark FROM vwsysUser WHERE bIsLock=0", "ID", "sUserCName", "sUserID,sUserCName,sUserEName,sDeptName,sRemark",
                           "用户编号,中文名,英文名,部门,备注", "员工信息");
        }

        /// <summary>
        ///初始化员工查询 
        /// </summary>
        /// <param name="lkp">LookUp控件</param>
        /// <param name="sReturnField">设置返回字段</param>
        public static void InitLkpSystemUser(BWS.ERP.Controls.BWSLookUp lkp,string sReturnField)
        {
            InitLookUpBase(lkp, "SELECT ID,sUserID,sUserCName,sUserEName,sDeptNo,sDeptName,sRemark FROM vwsysUser WHERE bIsLock=0", sReturnField, "sUserCName", "sUserID,sUserCName,sUserEName,sDeptName,sRemark",
                           "用户编号,中文名,英文名,部门,备注", "员工信息");
        }

        /// <summary>
        ///初始用户部门查询 
        /// </summary>
        /// <param name="lkp">LookUp控件</param>
        public static void InitLkpDept(BWS.ERP.Controls.BWSLookUp lkp)
        {
            InitLookUpBase(lkp, "SELECT ID,sDeptNo, sDeptName, sDeptEName, sRemark FROM hrDepartment", "ID", "sDeptName", "sDeptNo,sDeptName,sDeptEName,sRemark",
                           "部门编号,中文名称,英文名称,备注", "部门信息");
        }

        /// <summary>
        /// 初始化数据字典
        /// </summary>
        /// <param name="lkp">LookUp控件</param>
        /// <param name="sdictcategoryno">数据编号</param>
        public static void InitLkpDataDict(BWS.ERP.Controls.BWSLookUp lkp, string sdictcategoryno)
        {
            string sText = BWS.ERP.DataAccess.DbHelperSQL.GetSingle("SELECT sDictCategoryCName FROM basDataDictMaster WHERE sDictCategoryNo='" + sdictcategoryno + "'").ToString();
            InitLookUpBase(lkp, "SELECT sDictDataNo,sDictDataCName,sDictDataEName,sRemark FROM vwbasDataDictDetail WHERE bIsStop=0 AND sDictCategoryNo='" + sdictcategoryno + "'",
                           "sDictDataNo", "sDictDataCName", "sDictDataNo,sDictDataCName,sDictDataEName,sRemark", "编号,中文名称,英文名称,备注/说明", sText);
        }

        /// <summary>
        /// 选择币别
        /// </summary>
        /// <param name="lkp">LookUp控件</param>
        public static void InitLkpCurrency(BWS.ERP.Controls.BWSLookUp lkp)
        {
            InitLookUpBase(lkp, "SELECT sCurrencyID,sCurrencyCName,fExchangeRate,sRemark FROM basCurrency", 
                "sCurrencyID", "sCurrencyCName", "sCurrencyID,sCurrencyCName,fExchangeRate,sRemark", "编号,币别名称,英文名称,汇率,备注", "币别");
        }

        /// <summary>
        /// 选择单据
        /// </summary>
        /// <param name="lkp">LookUp控件</param>
        public static void InitLkpFormID(BWS.ERP.Controls.BWSLookUp lkp)
        {
            InitLookUpBase(lkp, "SELECT TOP 100 PERCENT iFormID,sMenuName FROM sysMenu WHERE iFormID<>0 ORDER BY iSort", 
                "iFormID", "sMenuName", "iFormID,sMenuName", "FormID,模块名称", "单据");
        }

        /// <summary>
        /// 选择门店信息
        /// </summary>
        /// <param name="lkp">LookUp控件</param>
        public static void InitLkpShopID(BWS.ERP.Controls.BWSLookUp lkp)
        {
            InitLookUpBase(lkp, "SELECT sShopID,sShopCName,sShopEName,sRemark FROM hrCompanyShopInfo", 
                "sShopID", "sShopCName", "sShopID,sShopCName,sShopEName,sRemark", "门店编号,门店名称,英文名称,备注", "门店");
        }

        /// <summary>
        /// 选择供应商
        /// </summary>
        /// <param name="lkp">LookUp控件</param>
        public static void InitLkpSupplier(BWS.ERP.Controls.BWSLookUp lkp)
        {
            InitLookUpBase(lkp, "SELECT ID,sSupplierID,sSupplierSName,sSupplierCName,sSupplierEName,sSupplierTypeName FROM vwbasSupplierMaster",
                "ID", "sSupplierSName", "sSupplierID,sSupplierSName,sSupplierCName,sSupplierEName,sSupplierTypeName",
                "供应商编号,供应商简称,供应商名称,英文名称,供应商类型", "供应商");
        }

        /// <summary>
        /// 选择供应商
        /// </summary>
        /// <param name="lkp">LookUp控件</param>
        /// <param name="sReturnField">设置返回字段</param>
        public static void InitLkpSupplier(BWS.ERP.Controls.BWSLookUp lkp,string sReturnField)
        {
            InitLookUpBase(lkp, "SELECT ID,sSupplierID,sSupplierSName,sSupplierCName,sSupplierEName,sSupplierTypeName FROM vwbasSupplierMaster",
                sReturnField, "sSupplierSName", "sSupplierID,sSupplierSName,sSupplierCName,sSupplierEName,sSupplierTypeName",
                "供应商编号,供应商简称,供应商名称,英文名称,供应商类型", "供应商");
        }

        /// <summary>
        /// 选择商品信息
        /// </summary>
        /// <param name="lkp"></param>
        public static void InitLkpGoodInfo(BWS.ERP.Controls.BWSLookUp lkp)
        {
            InitLookUpBase(lkp, "SELECT ID,sGoodID,sGoodCName,sGoodEName,sGoodTypeID,sUnitID,sShopID,sGoodTypeName,sUnitCName,sShopCName,ISNULL(fBasePrice,0) AS fBasePrice,ISNULL(fSalePrice,0) AS fSalePrice,dPriceDate FROM vwsalGoodInfoMasterView",
                "sGoodID", "sGoodCName", "sGoodID,sGoodCName,sGoodEName,sGoodTypeName,sUnitCName,sShopCName,fBasePrice,fSalePrice,dPriceDate", 
                "商品编号,商品名称,英文名称,商品类型,单位,所属门店,进价,销售价,价格日期", "商品信息");
        }
        /// <summary>
        /// 选择单据状态
        /// </summary>
        /// <param name="lkp"></param>
        public static void InitLkpFlag(BWS.ERP.Controls.BWSLookUp lkp)
        {
            InitLookUpBase(lkp, "SELECT ID,iFlag,sFlagName FROM basBillState", "iFlag", "sFlagName", "iFlag,sFlagName",
                "状态值,状态", "单据状态");
        }
        /// <summary>
        /// 从库存中选择商品
        /// </summary>
        /// <param name="lkp"></param>
        public static void InitLkpGoodInfoFromStock(BWS.ERP.Controls.BWSLookUp lkp)
        {
            string sSql = "SELECT sGoodID,sSpec,fBasePrice,fSalePrice,fQuantity,sGoodCName,sGoodEName,sGoodTypeID, "
                                + "sUnitID,sShopID,sGoodTypeName,sShopCName,sUnitName "
                                + "FROM vwstkGoodStkInfoView ";
            InitLookUpBase(lkp, sSql, "sGoodID", "sGoodID", "sGoodID,sGoodCName,sGoodEName,sSpec,sUnitName", "商品编号,商品名称,英文名称,规格,单位", "商品信息");
        }

        #endregion

        #region  公共方法

        /// <summary>
        /// 生成单据编号
        /// </summary>
        /// <param name="tablename">数据表名</param>
        /// <param name="fieldname">单据编号字段</param>
        /// <param name="prefix">前缀</param>
        /// <param name="datetype">日期格式</param>
        /// <param name="serialtype">序号格式，e.g：0000</param>
        /// <returns></returns>
        public static string GetBillNo(string tablename, string fieldname, string prefix, string datetype, string serialtype)
        {
            try
            {
                string sResult = "";
                string sDateFormatString = "";
                string sStr = "";
                if (datetype != "NULL" && datetype != "")
                {
                    sDateFormatString = DateTime.Now.Date.ToString(datetype);
                }
                //单据编号格式   前缀+日期+序列号
                sStr += prefix + sDateFormatString;
                string SQL = "SELECT MAX(" + fieldname + ") AS sBillNo FROM " + tablename
                           + " WHERE " + fieldname + " LIKE '"
                           + prefix + sDateFormatString + "%'"
                           + " AND LEN(" + fieldname + ")=" + (prefix + sDateFormatString + serialtype).Length.ToString();
                object obj = BWS.ERP.DataAccess.DbHelperSQL.GetSingle(SQL);
                if (obj != null)
                {
                    sResult = obj.ToString();
                }
                if (sResult == "")
                {
                    sResult = sStr + serialtype.Substring(0, serialtype.Length - 1) + "1";
                }
                else
                {
                    sResult = sResult.Substring(sStr.Length, serialtype.Length);
                    sResult = (Convert.ToInt32(sResult) + 1).ToString();
                    sResult = sStr + sResult.PadLeft(serialtype.Length, '0');
                }
                return sResult;
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// 设置单据编号
        /// </summary>
        /// <param name="formid"></param>
        /// <param name="drv"></param>
        public static void GetBillNo(int formid, DataRowView drv)
        {
            try
            {
                string tablename = "";
                string fieldname = "";
                string prefix = "";
                string datetype = "";
                string serialtype = "";
                string sSQL = "SELECT * FROM sysBillNoSet WHERE iFormID=" + formid.ToString();
                DataTable dtTemp = BWS.ERP.DataAccess.DbHelperSQL.Query(sSQL).Tables[0];
                if (dtTemp != null && dtTemp.Rows.Count > 0)
                {
                    tablename = dtTemp.Rows[0]["sTableName"].ToString();
                    fieldname = dtTemp.Rows[0]["sFieldName"].ToString();
                    prefix = dtTemp.Rows[0]["sPrefix"].ToString();
                    datetype = dtTemp.Rows[0]["sDateType"].ToString();
                    serialtype = dtTemp.Rows[0]["sSerialType"].ToString();
                }
                if (tablename != "" && fieldname != "" && datetype != "" && serialtype != "")
                {
                    drv[fieldname] = GetBillNo(tablename, fieldname, prefix, datetype, serialtype);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 设置单据编号
        /// </summary>
        /// <param name="formid"></param>
        /// <param name="drv"></param>
        public static void GetBillNo(int formid, DataRow dr)
        {
            try
            {
                string tablename = "";
                string fieldname = "";
                string prefix = "";
                string datetype = "";
                string serialtype = "";
                string sSQL = "SELECT * FROM sysBillNoSet WHERE iFormID=" + formid.ToString();
                DataTable dtTemp = BWS.ERP.DataAccess.DbHelperSQL.Query(sSQL).Tables[0];
                if (dtTemp != null && dtTemp.Rows.Count > 0)
                {
                    tablename = dtTemp.Rows[0]["sTableName"].ToString();
                    fieldname = dtTemp.Rows[0]["sFieldName"].ToString();
                    prefix = dtTemp.Rows[0]["sPrefix"].ToString();
                    datetype = dtTemp.Rows[0]["sDateType"].ToString();
                    serialtype = dtTemp.Rows[0]["sSerialType"].ToString();
                }
                if (tablename != "" && fieldname != "" && datetype != "" && serialtype != "")
                {
                    dr[fieldname] = GetBillNo(tablename, fieldname, prefix, datetype, serialtype);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        
        #endregion




    }
}
