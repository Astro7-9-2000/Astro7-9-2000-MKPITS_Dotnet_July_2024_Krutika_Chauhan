using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCViewDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string MyController()
        {
            return "Hi , I am your Controller";
        }

        public ActionResult MyView()
        {
            return View();
        }
    }
}