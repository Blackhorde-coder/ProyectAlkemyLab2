using AlkemyLabs2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlkemyLabs2.Filters
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple =false)]
    public class AutorizationUser : AuthorizeAttribute
    {
        private User oUser;
        private AlkemyLabs2Entities db = new AlkemyLabs2Entities();
        private int idOperation;

        public AutorizationUser(int idOperation = 0)
        {
            this.idOperation = idOperation;
        }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            String nameOperation = "";
            String nameModule = "";
            try
            {
                oUser = (User)HttpContext.Current.Session["User"];
                var lstOperations = from m in db.rol_operation
                                    where m.id_rol == oUser.rol && m.id_operation == idOperation
                                    select m;

                if (lstOperations.ToList().Count() == 0)
                {
                    var oOperation = db.operation.Find(idOperation);
                    int? idModule = oOperation.id_module;
                    nameOperation = getNameOperation(idOperation);
                    nameModule = getNameModule(idModule);
                    filterContext.Result = new RedirectResult("~/Error/UnauthorizedOperation=" + nameOperation + "&module=" + nameModule + "&msjeErrorExcepcion=");
                }
            }
            catch (Exception ex)
            {
                filterContext.Result = new RedirectResult("~/Error/UnauthorizedOperation?operation=" + nameOperation + "&module=" + nameModule + "&msjeErrorExcepcion=" + ex.Message);
            }

        }
        public string getNameOperation(int idOperation)
        {
            var ope = from op in db.operation
                      where op.id == idOperation
                      select op.name;
            String nameOperation;
            try
            {
                nameOperation = ope.First();
            }
            catch (Exception)
            {
                nameOperation = "";
            }
            return nameOperation;
        }
        public string getNameModule(int? idModule)
        {
            var module = from m in db.module
                         where m.id == idModule
                         select m.name;
            String nameModule;
            try
            {
                nameModule = module.First();
            }
            catch (Exception)
            {
                nameModule = "";
            }
            return nameModule;
        }

    }
}