using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_API_Service_with_Basic_Authentication.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
        public string Email { get; set; }
    }
}