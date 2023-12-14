
using Microsoft.AspNetCore.Mvc;

namespace Diana.Areas.Admin.Controllers
{
    
    public class DashboardController : Controller
    {
        [Area("Admin")]
       public IActionResult Index() { return View(); }
        
    }
}
