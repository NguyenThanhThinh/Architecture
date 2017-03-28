using Architecture.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Architecture.DAL
{
    public class DbConnection
    {
        private SqlConnection _sqlconnection;
        private string GetconnectString()
        {
            return ConfigurationManager.ConnectionStrings["apptest1"].ConnectionString;

        }
        private string GetconnectStringAuthen()
        {
            return ConfigurationManager.ConnectionStrings["apptest2"].ConnectionString;

        }
        public DbConnection()
        {
            _sqlconnection = new SqlConnection(GetconnectString());
        }
        public void ConnectionDb()
        {
            if (_sqlconnection.State != ConnectionState.Open)
            {
                try
                {
                    _sqlconnection.Open();
                }
                catch (SqlException ex)
                {

                    throw;
                }
            }
        }
        public DataTable ExecuteQuery(string sql)
        {
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, _sqlconnection);

                adapter.Fill(table);
            }
            catch (Exception)
            {

                throw;
            }
            return table;
        }
        public DataTable ExecuteQuery(string sql, ParameterPair[] param)
        {
            DataTable table = new DataTable();

            try
            {

                SqlCommand command = new SqlCommand(sql, _sqlconnection);
                SqlParameter p;
                for (int i = 0; i < param.Length; i++)
                {
                    ParameterPair pp = param[i];
                    p = new SqlParameter(pp.ParameterName, pp.Value);
                    command.Parameters.Add(p);
                }
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            return table;
        }
    }
}
