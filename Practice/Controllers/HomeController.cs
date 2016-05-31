﻿using System;
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