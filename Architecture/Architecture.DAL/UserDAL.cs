using Architecture.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.DAL
{
  public  class UserDAL
    {
        private DbConnection _dbconnection=null;
        public UserDAL()
        {
            _dbconnection = new DbConnection();
        }
        public DataTable GetUserById(int id)
        {
            string sql = @"";
            DataTable dt = _dbconnection.ExecuteQuery(sql, new ParameterPair[]
            {
                new ParameterPair("@id",id.ToString())
            });
            return dt;

        }

    }
}
