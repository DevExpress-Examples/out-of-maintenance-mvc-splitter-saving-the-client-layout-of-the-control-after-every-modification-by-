using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DXWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CallbackPanelPartial()
        {

            return PartialView("_CallbackPanelPartial");
        }
        [HttpPost]
        public ActionResult CallbackPanelPartial(string layout)
        {

            Session["layout"] = layout;
            return PartialView("_CallbackPanelPartial");
        }

    }
}
