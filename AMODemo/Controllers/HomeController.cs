using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMODemo.Controllers
{
    public class HomeController : Controller
    {
        private ITest _iTest;

        public HomeController(ITest ITest)
        {
            _iTest = ITest;
        }

        public string TestMethod()
        {
            return _iTest.TestMethod();
        }

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
    }
}