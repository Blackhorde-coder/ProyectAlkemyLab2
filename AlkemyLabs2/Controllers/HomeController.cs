using AlkemyLabs2.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlkemyLabs2.Controllers
{
    public class HomeController : Controller
    {
        [AutorizationUser(idOperation: 5)]
        public ActionResult Index()
        {
            return View();
        }
        [AutorizationUser(idOperation: 6)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [AutorizationUser(idOperation:7)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}