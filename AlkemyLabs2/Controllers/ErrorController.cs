using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlkemyLabs2.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult UnauthorizedOperation(String operation, String module, String msjeErrorException)
        {
            ViewBag.operation = operation;
            ViewBag.module = module;
            ViewBag.msjeErrorException = msjeErrorException;
            return View();
        }
    }
}