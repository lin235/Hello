﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Test1()
        {
            return View();
        }
        public ActionResult Test2()
        {
            return View();
        }
        public ActionResult Test3()
        {
            return View();
        }
    }
}
