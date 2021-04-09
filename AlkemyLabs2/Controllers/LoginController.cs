using AlkemyLabs2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlkemyLabs2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string user, string password, int type)
        {
            try
            {
                using (AlkemyLabs2Entities db = new AlkemyLabs2Entities())
                {
                    var oUser = (from d in db.User
                                 where d.email == user.Trim() && d.password == password.Trim() && d.rol == type
                                 select d).FirstOrDefault();
                    if (oUser == null)
                    {
                        ViewBag.Error = "Usuario o contraseña invalido";
                        return View();
                    }
                    Session["User"] = oUser;
                   
                }

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
    }

}