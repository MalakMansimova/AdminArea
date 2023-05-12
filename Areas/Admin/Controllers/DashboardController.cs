using Microsoft.AspNetCore.Mvc;

namespace WebAppLayout.Areas.Admin.Controllers
{
    public class DashboardController_cs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
