using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.DTO
{
  public  class User
    {
        public int Id { get; set; }

   
        public string Username { get; set; }

     
        public string Password_hash { get; set; }

  
        public string Auth_key { get; set; }

        public string Password { get; set; }

        public int? Status { get; set; }

        public string Email { get; set; }

   
        public string Avatar { get; set; }

        public int? Usertype { get; set; }

    
        public DateTime? last_login { get; set; }

        public DateTime? Last_updated { get; set; }

    
        public DateTime? Created_at { get; set; }

        public User()
        {
            Id = -1;
            Username = null;
            Password_hash = null;
            Password = null;Created_at = null;
            last_login = null;
            Created_at = null;
            Status = -1;
            Last_updated = null;
            Email = null;
            Usertype = -1;
        }
        public User(int id,string user,string password,string passwordHash,DateTime createAt,DateTime lastLogin,int status,DateTime updateAt,string email,int userType)
        {
            this.Id = id;
            this.Username = user;
            this.Password = password;
            this.Password_hash = passwordHash;
            this.Created_at = createAt;
            this.last_login = lastLogin;
            this.Status = status;
            this.Last_updated = updateAt;
            this.Email = email;
            this.Usertype = userType;
        }
    }
}
