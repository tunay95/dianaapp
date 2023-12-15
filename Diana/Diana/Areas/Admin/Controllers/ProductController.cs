using Diana.Areas.Admin.ViewModels;
using Diana.DAL;
using Diana.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Diana.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        AppDbContext _context { get; set; }
        IWebHostEnvironment _env { get; set; }
        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {

            List<Product> products = await _context.Products
                .Where(p => p.IsDeleted == false)
                .Include(p=>p.Category)

                .Include(p=>p.ProductColors)
                .ThenInclude(p=>p.Color)

                .Include(p=>p.ProductMaterials)
                .ThenInclude(p=>p.Material)

                .Include(p=>p.ProductSizes)
                .ThenInclude(p=>p.Size)

                .ToListAsync();

            return View(products);

        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            ViewBag.Colors = await _context.Colors.ToListAsync();
            ViewBag.Materials = await _context.Materials.ToListAsync();
            ViewBag.Sizes = await _context.Sizes.ToListAsync();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductVM createProductVM)
        {
            await _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View();
        }
        public async Task<IActionResult>Update(int id)
        {
            return View();
        }
    }
}
