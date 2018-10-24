using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCReview.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HandleError(View = "Error")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
            //throw new NullReferenceException();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public FileResult DownloadFile()
        {
            return new FilePathResult("C:\\Abhishek\\Project Templates\\AMO_Project_Upload.xlsx", "application/vnd.ms-excel");
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }
    }
}