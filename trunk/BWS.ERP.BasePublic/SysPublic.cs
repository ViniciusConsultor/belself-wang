//-------------------------------------------------------------------------------------------
//Name:             BWS.ERP.BaseForm.SysPublic
//Description:      ϵͳ��������������
//Create by:        Belself.Wang
//Create Date:      2010-7-26
//Modify by��              Modify Date��               Description��  
//Modify by��              Modify Date��               Description��  
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
    /// ϵͳ����������
    /// </summary>
    public class SysPublic
    {
        /// <summary>
        /// ���ؼ�Textֵ�Ƿ�Ϊ��
        /// </summary>
        /// <param name="ctl">��Ҫ��֤�Ŀؼ�</param>
        /// <param name="title">��ʾ����</param>
        /// <returns>True-Ϊ�գ�False-��Ϊ��</returns>
        public static bool CheckNotNull(Control ctl,string title)
        {
            if (ctl.Text == "")
            {
                BWS.ERP.BaseControl.Public.SystemInfo(title + "���ܹ�Ϊ�գ�");
                return true;
            }
            else
            {
                return false;
            }

        }        
        
        ////��� 
        //private static string[] TianGan = { "��", "��", "��", "��", "��", "��", "��", "��", "��", "��" };
        ////��֧ 
        //private static string[] DiZhi = { "��", "��", "��", "î", "��", "��", "��", "δ", "��", "��", "��", "��" };
        ////ʮ����Ф 
        //private static string[] ShengXiao = { "��", "ţ", "��", "��", "��", "��", "��", "��", "��", "��", "��", "��" };
        ////ũ������ 
        //private static string[] DayName = {"*","��һ","����","����","����","����", 
        //     "����","����","����","����","��ʮ", 
        //     "ʮһ","ʮ��","ʮ��","ʮ��","ʮ��", 
        //     "ʮ��","ʮ��","ʮ��","ʮ��","��ʮ", 
        //     "إһ","إ��","إ��","إ��","إ��", 
        //     "إ��","إ��","إ��","إ��","��ʮ"};
        ////ũ���·� 
        //private static string[] MonthName = { "*", "��", "��", "��", "��", "��", "��", "��", "��", "��", "ʮ", "ʮһ", "��" };
        ////�����¼����� 
        //private static int[] MonthAdd = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };
        ////ũ������ 
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

        //#region ��ȡ��Ӧ���ڵ�ũ��
        ///// <summary> 
        ///// ��ȡ��Ӧ���ڵ�ũ�� 
        ///// </summary> 
        ///// <param name="dtDay">��������</param> 
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
        //    //���㵽��ʼʱ��1921��2��8�յ�������1921-2-8(���³�һ) 
        //    nTheDate = (year - 1921) * 365 + (year - 1921) / 4 + day + MonthAdd[month - 1] - 38;
        //    if ((year % 4 == 0) && (month > 2))
        //        nTheDate += 1;
        //    //������ɣ���֧���£��� 
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
        //            //��ȡLunarData[m]�ĵ�n��������λ��ֵ 
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


        //    //��
        //    calendar = year + "��";
        //    //��Ф 
        //    calendar += ShengXiao[(year - 4) % 60 % 12].ToString() + "�� ";
        //    // //��� 
        //    calendar += TianGan[(year - 4) % 60 % 10].ToString();
        //    // //��֧ 
        //    calendar += DiZhi[(year - 4) % 60 % 12].ToString() + " ";

        //    //ũ���� 
        //    if (month < 1)
        //        calendar += "��" + MonthName[-1 * month].ToString() + "��";
        //    else
        //        calendar += MonthName[month].ToString() + "��";

        //    //ũ���� 
        //    calendar += DayName[day].ToString() + "��";
        //    return calendar;
        //}
        //#endregion
        //#region �ж�ĳ����ĳ�µĵڼ������ڼ�
        ///// <summary>
        ///// �ж�ĳ����ĳ�µĵڼ������ڼ�
        ///// </summary>
        ///// <param name="d">ʱ������</param>
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
        //public static int xingqi(string d)      //�ж����ڼ�
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
        //public static int WeekOfMonth(string d)      //�ڼ���
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
        /// ȡ�õ�ǰ���������ڼ�
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ChsWeek(DateTime date)
        {
            string week = date.DayOfWeek.ToString();
            switch (week)
            {
                case "Monday": return "����һ";
                case "Tuesday": return "���ڶ�";
                case "Wednesday": return "������";
                case "Thursday": return "������";
                case "Friday": return "������";
                case "Saturday": return "������";
                default: return "������";
            }
        }

        /// <summary>
        /// ȡ�õ�ǰʱ���ũ������
        /// </summary>
        /// <returns></returns>
        public static string CNDate()
        {
            System.Globalization.ChineseLunisolarCalendar l = new System.Globalization.ChineseLunisolarCalendar();
            DateTime dt = DateTime.Today; //ת�����յ�����
            string[] aMonth = { "", "����", "����", "����", "����", "����", "����", "����", "����", "����", "ʮ��", "ʮһ��", "����", "����" };

            string[] a10 = { "��", "ʮ", "��ʮ", "��ʮ" };
            string[] aDigi = { "��", "һ", "��", "��", "��", "��", "��", "��", "��", "��" };
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
            int iLeapMonth = l.GetLeapMonth(iYear); //��ȡ����

            if (iLeapMonth > 0 && iMonth <= iLeapMonth)
            {
                aMonth[iLeapMonth] = "��" + aMonth[iLeapMonth - 1];
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

            if (iDay == 10) sDay = "��ʮ";
            if (iDay == 20) sDay = "��ʮ";
            if (iDay == 30) sDay = "��ʮ";

            //Format Lunar Date
            sLuniSolarDate = sMonth + sDay;
            return sLuniSolarDate;
        }

        /// <summary>
        /// DataRowViewת��ΪDataTable
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
