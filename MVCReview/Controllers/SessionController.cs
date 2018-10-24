using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCReview.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.ReadOnly)]
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            Session["test"] = "Demo";
            Session["test"] = "update";
            return View();
        }

    }
}