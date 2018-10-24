using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCReview.Areas.Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Demo/Home
        public ActionResult Index()
        {
            TempData["test"] = "Test";
            //return RedirectToAction("M1");
            return View("Index");
        }

        public ActionResult M1()
        {
            var tempData = TempData["test"];
            return View("Index");
        }

        public ActionResult M2()
        {
            var tempData = TempData["test"];
            if (tempData == null)
                TempData["test"] = "Test in M2";

            return RedirectToAction("M3");
        }

        public ActionResult M3()
        {
            var tempData = TempData["test"];
            TempData.Keep("test");

            return View("Index", TempData["test"]);
        }

        public ActionResult M4()
        {
            var tempData = TempData.Peek("test");
            return View("Index");
        }

        public ActionResult M5()
        {
            var tempData = TempData["test"];
            return RedirectToAction("M1");
        }

    }
}