using Diana.DAL;
using Diana.Models;
using Diana.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Diana.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List <Product> products=_context.Products.ToList();
            HomeVM homeVM = new HomeVM()
            {
                Products = products
            };

            return View(homeVM);
        }
    }
}
