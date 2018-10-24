using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCReview.Controllers
{
    public class ExceptionController : Controller
    {
        // GET: Exception
        //[RequireHttps]
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        [RequireHttps]
        [OutputCache(Duration = 10)]
        public string ChildAction(string str)
        {
            return DateTime.Now.ToString();
        }

        [HandleError]
        public ActionResult TryCatch()
        {
            try
            {
                throw new NullReferenceException();
                return View();
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }

        public RedirectResult Redirect()
        {
            return Redirect("About");
        }

        public RedirectResult RedirectPermanent()
        {
            return RedirectPermanent("About");
        }

        public ActionResult About()
        {
            return View();
        }

    }
}