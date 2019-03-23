using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HackathonProject
{
    public class LichSu_DAL
    {
        public static List<LichSu> LoadLichSu()
        {
            string query = @"SELECT*FROM LICHSU";
            DataTable dataTable = new DataTable();//Can destroy.
            dataTable = DataProvider.QueryDataReader(query);
            LichSu lichSu;
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                List<LichSu> lstLichSu = new List<LichSu>();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    lichSu = new LichSu();
                    lichSu.MaLichSu = dataTable.Rows[i]["MALICHSU"].ToString();
                    lichSu.DoCaoBanDau = dataTable.Rows[i]["DOCAOBANDAU"].ToString();
                    lichSu.BanKinh = dataTable.Rows[i]["BANKINH"].ToString();
                    lichSu.KhoiLuongRiengChat = dataTable.Rows[i]["KHOILUONGRIENGCHAT"].ToString();
                    lichSu.KhoiLuongRiengVat = dataTable.Rows[i]["kHOILUONGRIENGVAT"].ToString();
                    lichSu.ThoiGianTongHop = dataTable.Rows[i]["THOIGIANTONGHOP"].ToString();
                    lstLichSu.Add(lichSu);
                }
                return lstLichSu;
            }
            return null;
        }

        public static bool InsertLichSu(LichSu lichSu)
        {
            /*Set query.*/
            string query = String.Format("INSERT INTO LICHSU (MALICHSU,DOCAOBANDAU,BANKINH,KHOILUONGRIENGCHAT,KHOILUONGRIENGVAT, THOIGIANTONGHOP) VALUES ('{0}','{1}','{2}','{3}','{4}', '{5}')", lichSu.MaLichSu, lichSu.DoCaoBanDau, lichSu.BanKinh, lichSu.KhoiLuongRiengChat,lichSu.KhoiLuongRiengVat,lichSu.ThoiGianTongHop);
            bool result = DataProvider.QueryExecuteNonQuery(query);/*Execute query in layer dataprovider.*/
            return result;

        }

        public static bool DeleteLichSu(string maLichSu)
        {
            /*Set query.*/
            string query = String.Format("DELETE FROM LICHSU WHERE MALICHSU='{0}'", maLichSu);
            bool result = DataProvider.QueryExecuteNonQuery(query);/*Execute query in layer dataprovider.*/
            return result;
        }

        public static string quantityElement()
        {

            string query = String.Format("SELECT * FROM LICHSU");
            DataTable dataTable = new DataTable();//Can destroy.
            dataTable = DataProvider.QueryDataReader(query);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[dataTable.Rows.Count - 1]["MALICHSU"].ToString();
            }
            else
            {
                return "LS-0";
            }

        }
    }
}

