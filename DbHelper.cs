using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCare_Pro
{
    public class DbHelper
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        public DbHelper()
        {
            //string connectionString = "Data Source=AKIB-LAPTOP\\SQLEXPRESS;Initial Catalog=AutoCarePro;Persist Security Info=True;User ID=sa;Password=password@Ak;Encrypt=False";
            string connectionString = "Data Source=RAFI\\SQLEXPRESS;Initial Catalog=AutoCarePro;Persist Security Info=True;User ID=sa;Password=rafi123;Encrypt=False";
            //string connectionString = "Data Source=AKIB\\SQLMAIN;Initial Catalog=AutoCarePro;Persist Security Info=True;User ID=sa;Password=password@Ak;Encrypt=False";
            this.Sqlcon = new SqlConnection(connectionString);
            Sqlcon.Open();
        }

        // Returns full DataSet — mirrors teacher's ExecuteQuery
        public DataSet GetData(string sqlQuery)
        {
            this.Sqlcom = new SqlCommand(sqlQuery, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds;
        }

        // Returns first DataTable — mirrors teacher's ExecuteQueryTable
        public DataTable GetDataTable(string sqlQuery)
        {
            this.Sqlcom = new SqlCommand(sqlQuery, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0];
        }

        // INSERT / UPDATE / DELETE — mirrors teacher's ExecuteDMLQuery
        public int ExecuteQuery(string sqlQuery)
        {
            this.Sqlcom = new SqlCommand(sqlQuery, this.Sqlcon);
            int rowsAffected = this.Sqlcom.ExecuteNonQuery();
            return rowsAffected;
        }

        // Returns single cell value as string — your original extra function
        public string ExecuteScalar(string sqlQuery)
        {
            this.Sqlcom = new SqlCommand(sqlQuery, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0].Rows[0][0].ToString();
        }
    }
}
