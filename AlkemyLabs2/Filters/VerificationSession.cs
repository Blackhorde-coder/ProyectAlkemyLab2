using AlkemyLabs2.Controllers;
using AlkemyLabs2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlkemyLabs2.Filters
{
    public class VerificationSession:ActionFilterAttribute
    {
        private User oUser;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                base.OnActionExecuting(filterContext);
                oUser = (User)HttpContext.Current.Session["User"];
                if (oUser == null)
                {
                    if (filterContext.Controller is LoginController == false)
                    {
                        filterContext.HttpContext.Response.Redirect("/Login/login");
                    }
                }
            }
            catch (Exception)
            {
                filterContext.Result = new RedirectResult("~/Login/Login");
            }

        adsad
        }
    }
}