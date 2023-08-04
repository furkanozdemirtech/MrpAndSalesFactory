using MrpAndSalesFactory.Models;
using System.Web.Mvc;

namespace MrpAndSalesFactory.Filters
{
    public class AuthAdmin : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (CurrentSession.User != null && CurrentSession.User.Rol == "Admin")
            {
                filterContext.Result = new RedirectResult("/Home/AccessDenied");
            }
        }
    }
}