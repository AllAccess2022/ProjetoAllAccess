using Microsoft.AspNetCore.Mvc;
using ProjetoAllAccess.Filters;
using ProjetoAllAccess.Models;
using System.Diagnostics;

namespace ProjetoAllAccess.Controllers
{
    
    public class HomeController : Controller
    {

        [PaginaParaUsuarioLogado]
        public IActionResult Index()
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