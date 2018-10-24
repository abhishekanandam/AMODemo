using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularDemo.Controllers
{
    public class DemoController : Controller
    {
        MusicStoreDataContext dbContext;
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Details()
        {
            dbContext = new MusicStoreDataContext();
            var data = dbContext.Artists.Select(s => s.Name ).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        // GET: Demo/Details/5
        public JsonResult DetailsById(int? id)
        {
            try
            {
                dbContext = new MusicStoreDataContext();
                var data = dbContext.Artists.Where(s => s.ArtistID == id).Select(x => x.Name).ToList();
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        // GET: Demo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Demo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Demo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Demo/Edit/5
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

        // GET: Demo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Demo/Delete/5
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
    }
}
