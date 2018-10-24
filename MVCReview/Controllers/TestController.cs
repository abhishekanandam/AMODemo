using Microsoft.Security.Application;
using MVCReview.Filters;
using MVCReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCReview.Controllers
{
   
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        // GET: Test/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Demo demo)
        {
            try
            {
                // TODO: Add insert logic here
                var url = HttpUtility.HtmlEncode(demo.PersonalWebSite);
                var xss = Sanitizer.GetSafeHtmlFragment(demo.PersonalWebSite);
                return RedirectToAction("Index", demo);
            }
            catch
            {
                return View();
            }
        }

        // GET: Test/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Test/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Test/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Test/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public RedirectResult Redirect()
        {
            return Redirect("http://csharp-video-tutorials.blogspot.com/2013/08/part-78-different-types-of-actionresult.html");
        }

        public RedirectToRouteResult RedirectToAction()
        {
            return RedirectToAction("Index");
        }

        public ContentResult Content()
        {
            return Content("Content Result Demo");
        }

        //public FileContentResult FileContent()
        //{
        //    return File("asdasd");
        //}

    }
}
