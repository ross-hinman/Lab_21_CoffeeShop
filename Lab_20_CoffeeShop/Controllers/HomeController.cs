using Lab_20_CoffeeShop;
using Lab_20_CoffeeShop.Models;
using Newtonsoft.Json;
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

        public ActionResult AddUser(string FirstName, string FavCoffee)
        {
            HttpCookie firstName;
            if (Request.Cookies["FirstName"] == null)
            {
                firstName = new HttpCookie("FirstName");
                firstName.Expires = DateTime.UtcNow.AddDays(1);
            }
            else
            {
                firstName = Request.Cookies["FirstName"];
                firstName.Expires = DateTime.UtcNow.AddDays(1);
            }
            firstName.Value = FirstName.ToString();
            Response.Cookies.Add(firstName);

            HttpCookie favCoffee;
            if (Request.Cookies["FavCoffee"] == null)
            {
                favCoffee = new HttpCookie("FavCoffee");
                favCoffee.Expires = DateTime.UtcNow.AddDays(1);
            }
            else
            {
                favCoffee = Request.Cookies["FavCoffee"];
                favCoffee.Expires = DateTime.UtcNow.AddDays(1);
            }
            favCoffee.Value = FavCoffee.ToString();
            Response.Cookies.Add(favCoffee);
            
            ViewBag.FavCoffee = FavCoffee;
            ViewBag.FirstName = FirstName;
            return View();
        }

        public int Counter { get; set; }
        public ActionResult Cart(PersonViewModel model)
        {
            HttpCookie cookie;
            if(Request.Cookies["CookieCounter"] == null)
            {
                cookie = new HttpCookie("CookieCounter");
                cookie.Value = "0";
                cookie.Expires = DateTime.UtcNow.AddDays(1);
            }
            else
            {
                cookie = Request.Cookies["CookieCounter"];
            }
            Counter = int.Parse(cookie.Value);
            Counter += 1;
            cookie.Value = Counter.ToString();
            Response.Cookies.Add(cookie);

            ViewBag.FirstName = model.FirstName;
            ViewBag.FavCoffee = model.FavCoffee;
            ViewBag.Message = $"You bought {Counter}";
            return View();
        }
        public ActionResult ClearCart()
        {
            var CookieCounter = new HttpCookie("CookieCounter");
            CookieCounter.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(CookieCounter);
            return RedirectToAction("Index", "Home");
        }

    }
}