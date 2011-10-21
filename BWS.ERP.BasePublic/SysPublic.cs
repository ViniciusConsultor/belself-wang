//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.BaseForm.SysPublic
//Description:      系统公共方法操作类
//Create by:        Belself.Wang
//Create Date:      2010-7-26
//Modify by：              Modify Date：               Description：  
//Modify by：              Modify Date：               Description：  
//-------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace BWS.ERP.BasePublic
{
    /// <summary>
    /// 系统公共方法类
    /// </summary>
    public class SysPublic
    {
        /// <summary>
        /// 检测控件Text值是否为空
        /// </summary>
        /// <param name="ctl">需要验证的控件</param>
        /// <param name="title">提示内容</param>
        /// <returns>True-为空，False-不为空</returns>
        public static bool CheckNotNull(Control ctl,string title)
        {
            if (ctl.Text == "")
            {
                BWS.ERP.BaseControl.Public.SystemInfo(title + "不能够为空！");
                return true;
            }
            else
            {
                return false;
            }

        }        
        
        ////天干 
        //private static string[] TianGan = { "甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "癸" };
        ////地支 
        //private static string[] DiZhi = { "子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥" };
        ////十二生肖 
        //private static string[] ShengXiao = { "鼠", "牛", "虎", "兔", "龙", "蛇", "马", "羊", "猴", "鸡", "狗", "猪" };
        ////农历日期 
        //private static string[] DayName = {"*","初一","初二","初三","初四","初五", 
        //     "初六","初七","初八","初九","初十", 
        //     "十一","十二","十三","十四","十五", 
        //     "十六","十七","十八","十九","二十", 
        //     "廿一","廿二","廿三","廿四","廿五", 
        //     "廿六","廿七","廿八","廿九","三十"};
        ////农历月份 
        //private static string[] MonthName = { "*", "正", "二", "三", "四", "五", "六", "七", "八", "九", "十", "十一", "腊" };
        ////公历月计数天 
        //private static int[] MonthAdd = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };
        ////农历数据 
        //private static int[] LunarData = {2635,333387,1701,1748,267701,694,2391,133423,1175,396438 
        //    ,3402,3749,331177,1453,694,201326,2350,465197,3221,3402 
        //    ,400202,2901,1386,267611,605,2349,137515,2709,464533,1738 
        //    ,2901,330421,1242,2651,199255,1323,529706,3733,1706,398762 
        //    ,2741,1206,267438,2647,1318,204070,3477,461653,1386,2413 
        //    ,330077,1197,2637,268877,3365,531109,2900,2922,398042,2395 
        //    ,1179,267415,2635,661067,1701,1748,398772,2742,2391,330031 
        //    ,1175,1611,200010,3749,527717,1452,2742,332397,2350,3222 
        //    ,268949,3402,3493,133973,1386,464219,605,2349,334123,2709 
        //    ,2890,267946,2773,592565,1210,2651,395863,1323,2707,265877};

        //#region 获取对应日期的农历
        ///// <summary> 
        ///// 获取对应日期的农历 
        ///// </summary> 
        ///// <param name="dtDay">公历日期</param> 
        ///// <returns></returns> 
        //public static string GetLunarCalendar(DateTime dtDay)
        //{

        //    string sYear = dtDay.Year.ToString();
        //    string sMonth = dtDay.Month.ToString();
        //    string sDay = dtDay.Day.ToString();
        //    int year;
        //    int month;
        //    int day;
        //    try
        //    {
        //        year = int.Parse(sYear);
        //        month = int.Parse(sMonth);
        //        day = int.Parse(sDay);
        //    }
        //    catch
        //    {
        //        year = DateTime.Now.Year;
        //        month = DateTime.Now.Month;
        //        day = DateTime.Now.Day;
        //    }
        //    int nTheDate;
        //    int nIsEnd;
        //    int k, m, n, nBit, i;
        //    string calendar = string.Empty;
        //    //计算到初始时间1921年2月8日的天数：1921-2-8(正月初一) 
        //    nTheDate = (year - 1921) * 365 + (year - 1921) / 4 + day + MonthAdd[month - 1] - 38;
        //    if ((year % 4 == 0) && (month > 2))
        //        nTheDate += 1;
        //    //计算天干，地支，月，日 
        //    nIsEnd = 0;
        //    m = 0;
        //    k = 0;
        //    n = 0;
        //    while (nIsEnd != 1)
        //    {
        //        if (LunarData[m] < 4095)
        //            k = 11;
        //        else
        //            k = 12;
        //        n = k;
        //        while (n >= 0)
        //        {
        //            //获取LunarData[m]的第n个二进制位的值 
        //            nBit = LunarData[m];
        //            for (i = 1; i < n + 1; i++)
        //                nBit = nBit / 2;
        //            nBit = nBit % 2;
        //            if (nTheDate <= (29 + nBit))
        //            {
        //                nIsEnd = 1;
        //                break;
        //            }
        //            nTheDate = nTheDate - 29 - nBit;
        //            n = n - 1;
        //        }
        //        if (nIsEnd == 1)
        //            break;
        //        m = m + 1;
        //    }
        //    year = 1921 + m;
        //    month = k - n + 1;
        //    day = nTheDate;
        //    //return year + "-" + month + "-" + day;
        //    if (k == 12)
        //    {
        //        if (month == LunarData[m] / 65536 + 1)
        //            month = 1 - month;
        //        else if (month > LunarData[m] / 65536 + 1)
        //            month = month - 1;
        //    }

        //    if (month < 10)
        //        calendar += "0" + month.ToString();
        //    else
        //        calendar += month.ToString();
        //    if (day <= 10)
        //        calendar += "0" + day.ToString();
        //    else
        //        calendar += day.ToString();


        //    //年
        //    calendar = year + "年";
        //    //生肖 
        //    calendar += ShengXiao[(year - 4) % 60 % 12].ToString() + "年 ";
        //    // //天干 
        //    calendar += TianGan[(year - 4) % 60 % 10].ToString();
        //    // //地支 
        //    calendar += DiZhi[(year - 4) % 60 % 12].ToString() + " ";

        //    //农历月 
        //    if (month < 1)
        //        calendar += "闰" + MonthName[-1 * month].ToString() + "月";
        //    else
        //        calendar += MonthName[month].ToString() + "月";

        //    //农历日 
        //    calendar += DayName[day].ToString() + "日";
        //    return calendar;
        //}
        //#endregion
        //#region 判断某天是某月的第几个星期几
        ///// <summary>
        ///// 判断某天是某月的第几个星期几
        ///// </summary>
        ///// <param name="d">时间日期</param>
        ///// <returns>1144</returns>
        //public static string xMxWx(string d)
        //{
        //    string xMxWxD = "";
        //    int xM, xW, xD;
        //    xM = Convert.ToDateTime(d).Month;
        //    if (xM < 10)
        //        xMxWxD += "0" + xM;
        //    else
        //        xMxWxD += xM;
        //    xW = WeekOfMonth(d);
        //    //   if (xW<10)
        //    //    xMxWxD+="0"+xW;
        //    //   else
        //    xMxWxD += xW;
        //    xD = xingqi(d);
        //    //   if (xD<10)
        //    //    xMxWxD+="0"+xD;
        //    //   else
        //    xMxWxD += xD;
        //    return xMxWxD;
        //}
        //public static int xingqi(string d)      //判断星期几
        //{
        //    int reslut = 0;
        //    string xq = Convert.ToDateTime(d).DayOfWeek.ToString();
        //    switch (xq)
        //    {
        //        case "Monday":
        //            reslut = 1;
        //            break;
        //        case "Tuesday":
        //            reslut = 2;
        //            break;
        //        case "Wednesday":
        //            reslut = 3;
        //            break;
        //        case "Thursday":
        //            reslut = 4;
        //            break;
        //        case "Friday":
        //            reslut = 5;
        //            break;
        //        case "Saturday":
        //            reslut = 6;
        //            break;
        //        case "Sunday":
        //            reslut = 0;
        //            break;
        //        default:
        //            reslut = 0;
        //            break;
        //    }
        //    return reslut;
        //}
        //public static int WeekOfMonth(string d)      //第几周
        //{
        //    DateTime day = Convert.ToDateTime(d);
        //    int daysOfWeek = 7;
        //    if (day.AddDays(0 - daysOfWeek).Month < day.Month)
        //        return 1;
        //    if (day.AddDays(0 - 2 * daysOfWeek).Month < day.Month)
        //        return 2;
        //    if (day.AddDays(0 - 3 * daysOfWeek).Month < day.Month)
        //        return 3;
        //    if (day.AddDays(0 - 4 * daysOfWeek).Month < day.Month)
        //        return 4;
        //    return 5;
        //}
        //#endregion

        /// <summary>
        /// 取得当前的中文星期几
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ChsWeek(DateTime date)
        {
            string week = date.DayOfWeek.ToString();
            switch (week)
            {
                case "Monday": return "星期一";
                case "Tuesday": return "星期二";
                case "Wednesday": return "星期三";
                case "Thursday": return "星期四";
                case "Friday": return "星期五";
                case "Saturday": return "星期六";
                default: return "星期日";
            }
        }

        /// <summary>
        /// 取得当前时间的农历日期
        /// </summary>
        /// <returns></returns>
        public static string CNDate()
        {
            System.Globalization.ChineseLunisolarCalendar l = new System.Globalization.ChineseLunisolarCalendar();
            DateTime dt = DateTime.Today; //转换当日的日期
            string[] aMonth = { "", "正月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "腊月", "腊月" };

            string[] a10 = { "初", "十", "二十", "三十" };
            string[] aDigi = { "Ｏ", "一", "二", "三", "四", "五", "六", "七", "八", "九" };
            string sYear = "", sYearArab = "", sMonth = "", sDay = "", sDay10 = "", sDay1 = "", sLuniSolarDate = "";
            int iYear, iMonth, iDay;
            iYear = l.GetYear(dt);
            iMonth = l.GetMonth(dt);
            iDay = l.GetDayOfMonth(dt);

            //Format Year
            sYearArab = iYear.ToString();
            for (int i = 0; i < sYearArab.Length; i++)
            {
                sYear += aDigi[Convert.ToInt16(sYearArab.Substring(i, 1))];
            }

            //Format Month
            int iLeapMonth = l.GetLeapMonth(iYear); //获取闰月

            if (iLeapMonth > 0 && iMonth <= iLeapMonth)
            {
                aMonth[iLeapMonth] = "闰" + aMonth[iLeapMonth - 1];
                sMonth = aMonth[l.GetMonth(dt)];
            }
            else if (iLeapMonth > 0 && iMonth > iLeapMonth)
            {
                sMonth = aMonth[l.GetMonth(dt) - 1];
            }
            else
            {
                sMonth = aMonth[l.GetMonth(dt)];
            }


            //Format Day
            sDay10 = a10[iDay / 10];
            sDay1 = aDigi[(iDay % 10)];
            sDay = sDay10 + sDay1;

            if (iDay == 10) sDay = "初十";
            if (iDay == 20) sDay = "二十";
            if (iDay == 30) sDay = "三十";

            //Format Lunar Date
            sLuniSolarDate = sMonth + sDay;
            return sLuniSolarDate;
        }

        /// <summary>
        /// DataRowView转换为DataTable
        /// </summary>
        /// <param name="drv">DataRowView</param>
        /// <returns>DataTable</returns>
        public static DataTable ConvertDataRowViewToTable(DataRowView drv)
        {
            DataTable dt = drv.DataView.Table.Clone();
            DataRow dr = dt.NewRow();
            for (int i = 0; i < drv.DataView.Table.Columns.Count; i++)
            {
                dr[i] = drv.Row[i];
            }
            dt.Rows.Add(dr);
            return dt;
        }
    }
}
