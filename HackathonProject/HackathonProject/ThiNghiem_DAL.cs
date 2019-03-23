using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HackathonProject
{
    public class ThiNghiem_DAL
    {
        public static List<ThiNghiem> LoadThiNghiem()
        {
            string query = @"SELECT*FROM THINGHIEM";
            DataTable dataTable = new DataTable();//Can destroy.
            dataTable = DataProvider.QueryDataReader(query);
            ThiNghiem thiNghiem;
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                List<ThiNghiem> lstThiNghiem = new List<ThiNghiem>();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    thiNghiem = new ThiNghiem();
                    thiNghiem.MaThiNghiem = dataTable.Rows[i]["ID"].ToString();
                    thiNghiem.MaVat = dataTable.Rows[i]["MAVAT"].ToString();
                    thiNghiem.MaDungDich = dataTable.Rows[i]["MADUNGDICH"].ToString();
                    thiNghiem.ThoiGianThucHien = (DateTime)dataTable.Rows[i]["THOIGIANTHUCHIEN"];
                    
                    lstThiNghiem.Add(thiNghiem);
                }
                return lstThiNghiem;
            }
            return null;
        }

        public static bool InsertThiNghiem(ThiNghiem thiNghiem)
        {
            /*Set query.*/
            string query = String.Format("INSERT INTO THINGHIEM (MATHINGHIEM,MAVAT,MADUNGDICH,THOIGIANTHUCHIEN) VALUES ('{0}','{1}','{2}','{3}')", thiNghiem.MaThiNghiem,thiNghiem.MaVat,thiNghiem.MaDungDich,thiNghiem.ThoiGianThucHien);
            bool result = DataProvider.QueryExecuteNonQuery(query);/*Execute query in layer dataprovider.*/
            return result;

        }

        public static bool DeleteThiNghiem(string maThiNghiem)
        {
            /*Set query.*/
            string query = String.Format("DELETE FROM THINGHIEM WHERE MATHIGNHIEM='{0}'", maThiNghiem);
            bool result = DataProvider.QueryExecuteNonQuery(query);/*Execute query in layer dataprovider.*/
            return result;
        }
    }
}
