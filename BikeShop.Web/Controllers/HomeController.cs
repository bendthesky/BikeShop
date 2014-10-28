using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace BikeShop.Web.Controllers
{
    public class HomeController : Controller
    {   
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var userRole = User.IsInRole("Admin");
            return View();
        }
       
            }
        }
        
    

