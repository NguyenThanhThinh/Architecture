using Architecture.DAL;
using Architecture.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.BLL
{
    public class UserBLL
    {
        private UserDAL _userDAL;

        public UserBLL()
        {
            _userDAL = new UserDAL();
        }
        public User GetUserByID(int id)
        {
            User _user;
            DataTable dt = _userDAL.GetUserById(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                int userID = int.Parse(dt.Rows[0]["id"].ToString());
                string userName = dt.Rows[0]["username"].ToString();
                string password_hash = dt.Rows[0]["password_hash"].ToString();
                DateTime createAt = DateTime.Parse(dt.Rows[0]["created_at"].ToString());
                DateTime lastLogin = DateTime.Parse(dt.Rows[0]["last_login"].ToString());
                DateTime lastUpdate = DateTime.Parse(dt.Rows[0]["last_updated"].ToString());
                int status = int.Parse(dt.Rows[0]["status"].ToString());
                int userType = int.Parse(dt.Rows[0]["usertype"].ToString());
                string email = dt.Rows[0]["email"].ToString();
                _user = new User(userID, userName, "", password_hash, createAt, lastLogin, status, lastUpdate, email, userType);

                return _user;
            }
            else
            {
                return null;
            }
        }
    }
}



