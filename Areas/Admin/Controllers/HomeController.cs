using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace WebAppLayout.Area.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            //[Area("Admin")]
             return View();
        }
    }
}
