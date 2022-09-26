using Microsoft.AspNetCore.Mvc;
using ProjetoAllAccess.Models;
using System.Diagnostics;

namespace ProjetoAllAccess.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Enem()
        {
            return View();
        }

        public IActionResult Fuvest()
        {
            return View();
        }

        public IActionResult Unicamp()
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