using Microsoft.AspNetCore.Mvc;
using System;

namespace WebAppLayout.Areas.Admin.Controllers
{
    public class CategoryController1 : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController1(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            ICallection<Category> categories = _context.Categories.ToListAsync();
            return View();
        }
    }
}
