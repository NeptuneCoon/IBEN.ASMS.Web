using Microsoft.AspNetCore.Mvc;

namespace IBEN.ASMS.Web.Controllers
{
    public class IncomeController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
