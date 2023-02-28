using System;
using System.Linq;


namespace BasicAuthenticationWEBAPI.Models
{
    public class UserValidate
    {
        //This method is used to check the user credentials
        public static bool Login(string username, string password)
        {
            UsersBL userBL = new UsersBL();
            var UserLists = userBL.GetUsers();
            return UserLists.Any(user =>
           //     user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
                user.UserName.Equals(username)
                && user.Password == password);
        }
    }
}