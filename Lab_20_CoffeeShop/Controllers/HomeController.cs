using Lab_20_CoffeeShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_20_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Please fill out the form to register!";
            return View();
        }

        public ActionResult AddUser(string FirstName, string LastName, string Email, string PhoneNumber)
        {
            ViewBag.Message = $"Hello {FirstName}";
            return View();
        }

    }
}