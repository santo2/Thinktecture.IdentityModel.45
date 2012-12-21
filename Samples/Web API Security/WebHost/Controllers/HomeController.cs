﻿using System.Web.Mvc;
using Thinktecture.Samples.Data;

namespace WebHost.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Web API security sample.";

            return View();
        }

        [Authorize]
        public ActionResult IdentityMvc()
        {
            return View(ViewClaim.GetAll());
        }

        [Authorize]
        public ActionResult IdentityApi()
        {
            return View();
        }
    }
}