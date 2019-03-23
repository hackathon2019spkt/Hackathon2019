using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HackathonProject
{
    public class DungDich_DAL
    {
        public static List<DungDich> LoadDungDich()
        {
            string query = @"SELECT*FROM DUNGDICH";
            DataTable dataTable = new DataTable();//Can destroy.
            dataTable = DataProvider.QueryDataReader(query);
            DungDich dungDichThiNghiem;
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                List<DungDich> lstDungDich = new List<DungDich>();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dungDichThiNghiem = new DungDich();
                    dungDichThiNghiem.MaDungDich = dataTable.Rows[i]["MADUNGDICH"].ToString();
                    dungDichThiNghiem.TenDungDich = dataTable.Rows[i]["TENDUNGDICH"].ToString();
                    dungDichThiNghiem.GiaTraiDungDich = dataTable.Rows[i]["GIATRIDUNGDICH"].ToString();
                    dungDichThiNghiem.ISDEFAUT = dataTable.Rows[i]["ISDEFAUT"].ToString();
                    lstDungDich.Add(dungDichThiNghiem);
                }
                return lstDungDich;
            }
            return null;
        }

        public static bool InsertDungDich(DungDich dungDichThiNghiem)
        {
            /*Set query.*/
            string query = String.Format("INSERT INTO DUNGDICH (MADUNGDICH,TENDUNGDICH,GIATRIDUNGDICH) VALUES ('{0}','{1}','{2}')", dungDichThiNghiem.MaDungDich, dungDichThiNghiem.TenDungDich, dungDichThiNghiem.GiaTraiDungDich);
            bool result = DataProvider.QueryExecuteNonQuery(query);/*Execute query in layer dataprovider.*/
            return result;

        }

        public static bool DeleteDungDich(string maDungDich)
        {
            /*Set query.*/
            string query = String.Format("DELETE FROM DUNGDICH WHERE MADUNGDICH='{0}'", maDungDich);
            bool result = DataProvider.QueryExecuteNonQuery(query);/*Execute query in layer dataprovider.*/
            return result;
        }
    }
}
