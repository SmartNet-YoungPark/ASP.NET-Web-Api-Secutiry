using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Role_based_Basic_Authentication_on_WEB_API.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Dept { get; set; }
        public int Salary { get; set; }
    }
}