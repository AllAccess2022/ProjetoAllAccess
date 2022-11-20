using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAllAccess.Data;
using ProjetoAllAccess.Filters;

namespace ProjetoAllAccess.Controllers
{
    [PaginaParaUsuarioLogado]
    public class FisController : Controller
    {
        private readonly Contexto _contexto;

        public FisController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> EnergiaIndex(int id)
        {
            var context = _contexto.Conteudos.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
        
        public async Task<IActionResult> LeiNewtonIndex(int id)
        {
            var context = _contexto.Conteudos.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
        public async Task<IActionResult> TrabalhoIndex(int id)
        {
            var context = _contexto.Conteudos.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
        public async Task<IActionResult> MecanicaIndex(int id)
        {
            var context = _contexto.Conteudos.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
        public IActionResult FisIndex()
        {
            return View();
        }
    }
}
