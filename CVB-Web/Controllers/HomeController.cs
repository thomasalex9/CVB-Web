using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVB_Web.ViewModels;

namespace CVB_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ConsultantDashboard cdb = new ConsultantDashboard(7);
            return View(cdb);
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

        public ActionResult ReferenceTables()
        {
            return View();
        }

    }
}