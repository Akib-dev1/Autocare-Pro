using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_Pro
{
    internal static class DbHelper
    {
        //private static string connectionString = "Data Source=AKIB\\SQLMAIN;Initial Catalog=AutoCarePro;Persist Security Info=True;User ID=sa;Password=password@Ak;Encrypt=False";
        private static string connectionString = "Data Source=AKIB-LAPTOP\\SQLEXPRESS;Initial Catalog=AutoCarePro;Persist Security Info=True;User ID=sa;Password=password@Ak;Encrypt=False";
        
        public static DataSet GetData(string sqlQuery)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand sql = new SqlCommand(sqlQuery, sqlCon);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataSet ds = new DataSet();
            sqlData.Fill(ds);
            sqlCon.Close();
            return ds;
        }
        
        public static int ExecuteQuery(string sqlQuery)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand sql = new SqlCommand(sqlQuery, sqlCon);
            int rowsAffected = sql.ExecuteNonQuery();
            sqlCon.Close();
            return rowsAffected;
        }

        public static string ExecuteScalar(string sqlQuery)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand sql = new SqlCommand(sqlQuery, sqlCon);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataSet ds = new DataSet();
            sqlData.Fill(ds);
            sqlCon.Close();
            return ds.Tables[0].Rows[0][0].ToString();
        }
    }
}
