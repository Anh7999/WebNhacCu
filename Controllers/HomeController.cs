﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web12.Models;

namespace web12.Controllers
{
    public class HomeController : Controller
    {
        web1Entities1 db = new web1Entities1();
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

        public ActionResult Login()
    }
}