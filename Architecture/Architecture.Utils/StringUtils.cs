using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Utils
{
  public static  class StringUtils
    {
        public static string EncryptPassword(string input)
        {
            StringBuilder strBuilder = new StringBuilder();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(new UTF8Encoding().GetBytes(input));
            for (int i = 0; i < bytes.Length; i++)
            {
                strBuilder.Append(bytes[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
    }
}
