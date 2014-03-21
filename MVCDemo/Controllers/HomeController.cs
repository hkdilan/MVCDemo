﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id, string name)
        {
            ViewBag.Countries = new List<string>()
            {
                "Sri Lanka",
                "India",
                "USA",
                "Australia"
            };
            return View();
        }

    }
}
