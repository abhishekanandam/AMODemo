using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCReview.Controllers
{
    public class ProvidersController : Controller
    {
        // GET: Providers
        [HttpGet]
        public ActionResult Index()
        {
            HttpContext.Response.Cookies.Add(new HttpCookie("Id", "Emp001"));
            return View();
        }


        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateAntiForgeryToken]
        public string IndexPost(string Id)
        {
            return Id;
        }
    }
}