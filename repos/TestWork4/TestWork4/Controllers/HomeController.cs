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

namespace TestWork4.Controllers
{
    public class HomeController : Controller
    {
        //private ApplicationUserManager _userManager;

        //public ApplicationUserManager UserManager
        //{
        //    get
        //    {
        //        return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
        //    }
        //    private set
        //    {
        //        _userManager = value;
        //    }
        //}

        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Lk()           
        {
            //var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
            var identity = new ClaimsIdentity(User.Identity);
            //identity.RemoveClaim(identity.FindFirst("name"));
            //identity.AddClaim(new Claim("name",));

            ViewBag.Email = HttpContext.User.Identity.Name;
            ViewBag.Name = identity.Claims.Where(c => c.Type == "name").Select(c => c.Value).SingleOrDefault();
            ViewBag.LastName = identity.Claims.Where(c => c.Type == "lastName").Select(c => c.Value).SingleOrDefault();
            ViewBag.Age = identity.Claims.Where(c => c.Type == "age").Select(c => c.Value).SingleOrDefault();
            ViewBag.City = identity.Claims.Where(c => c.Type == "city").Select(c => c.Value).SingleOrDefault();
            return View();
        }
    }
}