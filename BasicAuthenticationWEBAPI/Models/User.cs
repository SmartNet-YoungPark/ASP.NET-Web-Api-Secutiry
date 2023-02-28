using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthenticationWEBAPI.Models
{
    public class User
    {
        public int ID { get; set; }
        public object UserName { get; set; }
        public string Password { get; set; }

    }
}