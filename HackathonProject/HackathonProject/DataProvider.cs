using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HackathonProject
{
    public class DataProvider
    {
        public static SqlConnection Connect()
        {
            string sqlConnect = @"Data Source=(local);Initial Catalog=HACKATHONPHYSICS;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlConnect);
            conn.Open();
            return conn;
        }

        //*Data adapter*/
        public static DataTable QueryDataTable(string query)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Connect());
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                Connect().Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                Connect().Close();
                return null;
            }

        }

        /*DataReader. Use with a big data.*/
        public static DataTable QueryDataReader(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, Connect());
                SqlDataReader dataReader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);

                Connect().Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                Connect().Close();
                return null;
            }

        }

        public static bool QueryExecuteNonQuery(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, Connect());
                int iCMD = cmd.ExecuteNonQuery();
                Connect().Close();
                if (iCMD > 0)
                {
                    return true;
                }
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                Connect().Close();
                return false;
            }
        }
    }
}
