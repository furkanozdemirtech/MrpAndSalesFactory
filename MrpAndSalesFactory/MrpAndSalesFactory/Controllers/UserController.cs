using MrpAndSalesFactory.Entity.ValueObject;
using System.Web.Mvc;

namespace MrpAndSalesFactory.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FillUserObjectsLogin model)
        {

            return View();
        }
    }
}