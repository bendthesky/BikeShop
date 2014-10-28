using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace BikeShop.Web.Controllers
{
    [Authorize]
    public class ApiLoginController : ApiController
    {
        public IHttpActionResult GET()
        {
            var role = User.IsInRole("Admin");
            return Ok(role);
        }
    }
}
