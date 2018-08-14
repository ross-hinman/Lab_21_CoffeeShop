using Lab_20_CoffeeShop;
using Lab_20_CoffeeShop.Models;
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
            ViewBag.Message = "This is all about GC Coffee!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Our contact page.";

            return View();
        }

        public ActionResult RegisterPerson(PersonViewModel model)
        {
            ViewBag.Message = "Please fill out the form to register!";
            return View(model);
        }

        public ActionResult AddUser(string FirstName)
        {
            ViewBag.FirstName = FirstName;
            return View();
        }

    }
}