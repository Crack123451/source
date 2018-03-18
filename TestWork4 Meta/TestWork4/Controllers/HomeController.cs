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
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Lk()
        {
            var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
            ViewBag.Email = HttpContext.User.Identity.Name;
            ViewBag.Name = identity.Claims.Where(c => c.Type == "name").Select(c => c.Value).SingleOrDefault();
            ViewBag.LastName = identity.Claims.Where(c => c.Type == "lastName").Select(c => c.Value).SingleOrDefault();
            ViewBag.Age = identity.Claims.Where(c => c.Type == "age").Select(c => c.Value).SingleOrDefault();
            ViewBag.City = identity.Claims.Where(c => c.Type == "city").Select(c => c.Value).SingleOrDefault();
            //return "<p>Эл. адрес: " + email + "</p><p>Имя:" + name + "</p><p>Фамилия:" + lastName + "</p><p> Возраст:" + age + "</p><p> Город:" + city + "</p>";

            return View();
        }
    }
}