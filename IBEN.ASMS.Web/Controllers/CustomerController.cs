using IBEN.ASMS.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace IBEN.ASMS.Web.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Customer customer)
        {

            return RedirectToAction("List", "Customer");
        }
    }
}
