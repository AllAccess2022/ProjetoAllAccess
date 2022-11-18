using Microsoft.AspNetCore.Mvc;
using ProjetoAllAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace ProjetoAllAccess.Controllers
{
    public class MatController : Controller
    {
        private readonly Contexto _contexto;

        public MatController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> NocoesConjuntosIndex(int id)
        {
            var context = _contexto.Conteudos.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
        public async Task<IActionResult> EstatisticaIndex(int id)
        {
            var context = _contexto.Conteudos.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
        public async Task<IActionResult> ConjuntosNumericosIndex(int id)
        {
            var context = _contexto.Conteudos.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
        public async Task<IActionResult> FuncoesIndex(int id)
        {
            var context = _contexto.Conteudos.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
        public IActionResult MatIndex()
        {
            return View();
        }
    }
}
