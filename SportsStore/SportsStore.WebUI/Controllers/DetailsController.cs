﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact_Us()
        {
            return View();
        }
    }
}