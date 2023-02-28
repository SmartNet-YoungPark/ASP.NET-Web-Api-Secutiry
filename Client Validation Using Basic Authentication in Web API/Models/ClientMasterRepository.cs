using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client_Validation_Using_Basic_Authentication_in_Web_API.Models
{
    public class ClientMasterRepository : IDisposable
    {
        // SECURITY_DBEntities it is your context class
        EmployeeDBEntities context = new EmployeeDBEntities();
        //This method is used to check and validate the Client credentials
        public ClientMaster ValidateClient(string ClientID, string ClientSecret)
        {
            return context.ClientMasters.FirstOrDefault(user=>
            String.Concat(user.ClientId) == ClientID
            && String.Concat(user.ClientSecret) == ClientSecret);

        }
        public void Dispose()
        {
           context.Dispose();
        }
    }


}