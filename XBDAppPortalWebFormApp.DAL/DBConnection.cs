using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using XBDAppWebFormApp.DTO;

namespace XBDAppPortalWebFormApp.DAL
{
    public class DBConnection
    {
        private string connStr;
 
        public DBConnection()
        {
            connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        }

        public DataSet GetDataSet(string strCmdTxt)
        {
            DataSet ds = new DataSet();
            
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connStr;
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = strCmdTxt;
                    comm.Connection = conn;
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    adapter.Fill(ds);
                    conn.Close();
                }
            }
                
            

            return ds;
            
        }
 




      
        public DataSet GetDataSet(string strCmdTxt, IList<SqlParameter> parameters)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connStr;
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    conn.Open();
                    comm.CommandText = strCmdTxt;
                    comm.CommandType = CommandType.StoredProcedure;

                    foreach (SqlParameter p in parameters)
                    {
                        comm.Parameters.Add(p);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(comm);

                    adapter.Fill(ds);

                    conn.Close();

                }
                return ds;
                }
        }
        public DataSet GetDataSet(string strCmdTxt, SqlParameter parameter)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connStr;
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    conn.Open();
                    comm.CommandText = strCmdTxt;
                    comm.CommandType = CommandType.StoredProcedure;

                    comm.Parameters.Add(parameter);

                    SqlDataAdapter adapter = new SqlDataAdapter(comm);

                    adapter.Fill(ds);

                    conn.Close();

                }
                return ds;
            }
        }
        


    }
}
