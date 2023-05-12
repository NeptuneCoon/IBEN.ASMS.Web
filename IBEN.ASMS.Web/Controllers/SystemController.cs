using Microsoft.AspNetCore.Mvc;

namespace IBEN.ASMS.Web.Controllers
{
    public class SystemController : Controller
    {
        public IActionResult Dict()
        {
            return View();
        }
    }
}
