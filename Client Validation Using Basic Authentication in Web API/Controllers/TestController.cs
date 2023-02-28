using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace Client_Validation_Using_Basic_Authentication_in_Web_API.Controllers
{
    public class TestController : ApiController
    {
        //This resource is For all types of role
        [Authorize(Roles = "SuperAdmin, Admin, User")]
        [HttpGet]
        [Route("api/test/resource")]
        public IHttpActionResult GetResource()
        {
            var identity = (ClaimsIdentity)User.Identity;

            var ClientId = identity.Claims.FirstOrDefault(c => c.Type == "ClientId").Value;
            var ClientName = identity.Claims.FirstOrDefault(c => c.Type == "ClientName").Value;
            var ClientSecret = identity.Claims.FirstOrDefault(c => c.Type == "ClientSecret").Value;

            return Ok("Hello: " + identity.Name + ", Client Name is = " + ClientName);

            //var identity = (ClaimsIdentity)User.Identity;
            //return Ok("Hello: " + identity.Name);
        }

    }
}
