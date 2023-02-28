using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Basic_Authentication_Using_Message_Handler_in_Web_API.Models
{
    public class ValidateUser
    {
        //This method is used to check the user credentials
        public UserMaster CheckUserCredentials(string username, string password)
        {
            // SECURIRT_DBEntities it is your context class
           // using (var context = new SECURIRT_DBEntities())
            using (var context = new EmployeeDBEntities())
            {
                return context.UserMasters.FirstOrDefault(user =>
                user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
                && user.UserPassword == password);
            }
        }
    }
}