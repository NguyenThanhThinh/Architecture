using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Utils
{
   public class Common
    {
        public enum UserType
        {
            Emoloyee=1,
            Customer=2
        }
        public enum CustomType
        {
            Retail_Customer=4,
            Preferred_Customer=5
        }
        public enum EmployeeType
        {
            Admin=1,
            Staff=2,
            Collaborator=3
        }
        public enum UserStatus
        {
            Inactive=0,
            Disabled=1,
            Active=3,
            Deleted=4

        }
    }
}
