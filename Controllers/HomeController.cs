using BaiThucHanh1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaiThucHanh1.Controllers
{
    public class HomeController : Controller
    {
        QlbanVaLiContext db= new QlbanVaLiContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var lstsp= db.TDanhMucSps.ToList(); 
            return View(lstsp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
