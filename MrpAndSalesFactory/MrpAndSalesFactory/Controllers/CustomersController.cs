using MrpAndSalesFactory.Entity.Models;
using System.Web.Mvc;

namespace MrpAndSalesFactory.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Cari _model)
        {
            return View();
        }
    }
}