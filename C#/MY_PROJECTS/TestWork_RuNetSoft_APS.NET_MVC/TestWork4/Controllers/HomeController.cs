using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using TestWork4.Models;
using TestWork4.Common.Extensions;

namespace TestWork4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Lk()           
        {
            var identity = new ClaimsIdentity(User.Identity);
            ViewBag.Email = HttpContext.User.Identity.Name;
            ViewBag.Name = User.GetClaimValue("Name") == null ? identity.Claims.Where(c => c.Type == "name").Select(c => c.Value).SingleOrDefault() : User.GetClaimValue("Name");
            ViewBag.LastName = User.GetClaimValue("LastName") == null ? identity.Claims.Where(c => c.Type == "lastName").Select(c => c.Value).SingleOrDefault() : User.GetClaimValue("LastName");
            ViewBag.Age = User.GetClaimValue("Age") ==null ? identity.Claims.Where(c => c.Type == "age").Select(c => c.Value).SingleOrDefault() : User.GetClaimValue("Age");
            ViewBag.City = User.GetClaimValue("City") ==null ? identity.Claims.Where(c => c.Type == "city").Select(c => c.Value).SingleOrDefault() : User.GetClaimValue("City");
            return View();
        }
    }
}