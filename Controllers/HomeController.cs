using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using WebAppLayout.ViewModels;

namespace WebAppLayout.Controllers
{
    public class HomeController : Controller
    {
        public List<Group> Groups { get; set; } = new List<Group>();
        public string[] Students = { "Malak","Narmin","Nigar","Sabina" };
        //{
        //    new Group
        //    { Id = 1,
        //      Name="AB-201",
        //      Count=18
        //    },
        //    new Group
        //    {
        //        Id=2,
        //        Name="BB-201",
        //        Count=20
        //    }

        //};

        public IActionResult Index()
        {
            //Tuple
            //(List<Group>, string[])homeTuple=(Groups, Students);
            HomeVM homeVM = new HomeVM() { Students = Students, Groups = Groups };
            
            return View(homeVM);
            //return View(group);
        }
        public IActionResult Show()
        {
            return View();
        }
    }
}
