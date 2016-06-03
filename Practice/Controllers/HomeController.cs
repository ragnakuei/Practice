using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Index";
            return View();
        }

        public ActionResult _Partial_02()
        {
            ViewBag.Title = "Partial";
            return PartialView();
        }

        public ActionResult Index_01()
        {
            ViewBag.Title = "Index";
            return View();
        }

        public ActionResult Index_02()
        {
            ViewBag.Title = "Index";
            return View();
        }

        public ActionResult Index_03()
        {
            ViewBag.Title = "Index";
            return View();
        }

        public ActionResult Index_04()
        {
            ViewBag.Title = "Index";
            ViewData["Title"] = "Index04";
            return View();
        }

        public ActionResult Index_05()
        {
             Book[] books = new Book[] 
            {
                new Book { id=1,name="Book1" },
                new Book { id=2,name="Book2" },
                new Book { id=3,name="Book3" }
            };
            ViewBag.books = books;
            return View(books);
        }

        public ActionResult helper()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult link()
        {
            return View();
        }

        public ActionResult encode()
        {
            return View();
        }

        public ActionResult raw()
        {
            return View();
        }

        public ActionResult helper01()
        {
            return View();
        }

        public ActionResult function()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Get()
        {
            return View();
        }
    }
}