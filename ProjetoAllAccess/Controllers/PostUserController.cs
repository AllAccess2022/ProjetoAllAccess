using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAllAccess.Data;

namespace ProjetoAllAccess.Controllers
{
    public class PostUserController : Controller
    {

        private readonly Contexto _context;

        public PostUserController(Contexto context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.PostUser.ToListAsync());
        }

        public async Task<IActionResult> PostConteudo(int id)
        {
            var context = _context.PostUser.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
        public IActionResult CriarPost()
        {
            return View();
        }
    }
}
