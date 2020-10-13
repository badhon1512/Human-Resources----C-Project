using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;

namespace HRUpdate.DB
{
    public class DataAccess
    {



        private static SqlConnection sqlCon;

        public static SqlConnection SqlCon
        {
            get
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(@"Data Source=DESKTOP-GGPVJTF;Initial Catalog=universal;Persist Security Info=True;User ID=sa;Password=54812");
                }
                else if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                }
                return sqlCon;
            }
        }

        private static DataSet GetDataSet(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, SqlCon);
            SqlDataAdapter sda = new SqlDataAdapter(sqcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public static DataTable ExecuteQuery(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }

        public static int ExecuteUpdate(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, SqlCon);
            return sqcom.ExecuteNonQuery();
        }











       
       
        public static string SingleVarification(string sql)
        {
            DataTable dt;
            try
            {
                dt = ExecuteQuery(sql);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                return dt.Rows[0][0].ToString();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
                return null;
            }



        }
      
        public static int CountMethod(string sql)
        {
            //stri count=null;
            try
            {
                SqlCommand SqlCom = new SqlCommand(sql, SqlCon);
              SqlCom.Connection = SqlCon;

                int Count = Convert.ToInt32(SqlCom.ExecuteScalar());
                return Count;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

            return 0;
        }
    }
}
