using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HackathonProject
{
    public class SaveExp_DAL
    {
        public static List<SaveExp> LoadSave()
        {
            string query = @"SELECT*FROM SAVEEXP";
            DataTable dataTable = new DataTable();//Can destroy.
            dataTable = DataProvider.QueryDataReader(query);
            SaveExp saveEx;
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                List<SaveExp> lstSaveExp = new List<SaveExp>();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    saveEx = new SaveExp();
                    saveEx.ID = dataTable.Rows[i]["ID"].ToString();
                    saveEx.Ngay = (string)dataTable.Rows[i]["NGAY"];
                    saveEx.Y = (int)dataTable.Rows[i]["Y"];        
                    saveEx.Vt =float.Parse(dataTable.Rows[i]["VT"].ToString());
                    saveEx.ThoiGian =float.Parse(dataTable.Rows[i]["THOIGIAN"].ToString());
                    saveEx.A = float.Parse(dataTable.Rows[i]["A"].ToString());
                    saveEx.BanKinh = float.Parse(dataTable.Rows[i]["BANKINH"].ToString());
                    saveEx.KhoiLuongRiengVat = float.Parse(dataTable.Rows[i]["KHOILUONGRIENGVAT"].ToString());
                    saveEx.KhoiLuongRiengChat = float.Parse(dataTable.Rows[i]["KHOILUONGRIENGCHAT"].ToString());
                    saveEx.X = (int)dataTable.Rows[i]["X"];
                    lstSaveExp.Add(saveEx);
                }
                return lstSaveExp;
            }
            return null;
        }

        public static bool InsertSave(SaveExp saveExp)
        {
            /*Set query.*/
            string query = String.Format("INSERT INTO SAVEEXP (ID,NGAY,Y,VT,THOIGIAN,A,BANKINH,KHOILUONGRIENGVAT,KHOILUONGRIENGCHAT,X) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", saveExp.ID, saveExp.Ngay, saveExp.Y,  saveExp.Vt, saveExp.ThoiGian, saveExp.A, saveExp.BanKinh, saveExp.KhoiLuongRiengVat,saveExp.KhoiLuongRiengChat,saveExp.X);
            bool result = DataProvider.QueryExecuteNonQuery(query);/*Execute query in layer dataprovider.*/
            return result;

        }

        public static bool DeleteSave(string id)
        {
            /*Set query.*/
            string query = String.Format("DELETE FROM SAVEEXP WHERE ID='{0}'", id);
            bool result = DataProvider.QueryExecuteNonQuery(query);/*Execute query in layer dataprovider.*/
            return result;
        }

        public static string quantityElement()
        {
            
            string query=String.Format("SELECT * FROM SAVEEXP");
            DataTable dataTable = new DataTable();//Can destroy.
            dataTable = DataProvider.QueryDataReader(query);
            
            if(dataTable!=null && dataTable.Rows.Count>0)
            {
                return dataTable.Rows[dataTable.Rows.Count-1]["ID"].ToString();
            }
            else
            {
                return "ID-0";
            }
               
        }
    }
}
