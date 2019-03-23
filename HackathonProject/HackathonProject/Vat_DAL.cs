using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HackathonProject
{
    public class Vat_DAL
    {
        public static List<Vat> LoadVat()
        {
            string query = @"SELECT*FROM VAT";
            DataTable dataTable = new DataTable();//Can destroy.
            dataTable = DataProvider.QueryDataReader(query);
            Vat vatThiNghiem;
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                List<Vat> lstVat = new List<Vat>();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    vatThiNghiem = new Vat();
                    vatThiNghiem.MaVat = dataTable.Rows[i]["MAVAT"].ToString();
                    vatThiNghiem.TenVat = dataTable.Rows[i]["TENVAT"].ToString();
                    vatThiNghiem.GiaTriVat = dataTable.Rows[i]["GIATRIVAT"].ToString();
                    vatThiNghiem.ISDEFAUT = dataTable.Rows[i]["ISDEFAUT"].ToString();
                    lstVat.Add(vatThiNghiem);
                }
                return lstVat;
            }
            return null;
        }

        public static bool InsertVat(Vat vatThiNghiem)
        {
            /*Set query.*/
            string query = String.Format("INSERT INTO VAT (MAVAT,TENVAT,GIATRIVAT,ISDEFAUT) VALUES ('{0}','{1}','{2}','{3}')", vatThiNghiem.MaVat, vatThiNghiem.TenVat, vatThiNghiem.GiaTriVat,vatThiNghiem.ISDEFAUT);
            bool result = DataProvider.QueryExecuteNonQuery(query);/*Execute query in layer dataprovider.*/
            return result;

        }

        public static bool DeleteVat(string maVat)
        {
            /*Set query.*/
            string query = String.Format("DELETE FROM VAT WHERE MAVAT='{0}'",maVat);
            bool result = DataProvider.QueryExecuteNonQuery(query);/*Execute query in layer dataprovider.*/
            return result;
        }
    }
}
