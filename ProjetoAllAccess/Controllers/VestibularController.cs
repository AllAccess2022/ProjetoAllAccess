using Microsoft.AspNetCore.Mvc;
using ProjetoAllAccess.Data;
using Microsoft.EntityFrameworkCore;
using ProjetoAllAccess.Filters;

namespace ProjetoAllAccess.Controllers
{
    [PaginaParaUsuarioLogado]
    public class VestibularController : Controller
    {
        private readonly Contexto _contexto;

        public VestibularController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public IActionResult IndexVestibular()
        {
            return View();
        }
        public IActionResult ExerciciosVestibular()
        {
            return View();
        }
        public async Task<IActionResult> ExerciciosEnemIndex(int id)
        {
            var context = _contexto.ExVest.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
        public async Task<IActionResult> ExerciciosFuvestIndex(int id)
        {
            var context = _contexto.ExVest.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
        public async Task<IActionResult> ExerciciosComvestIndex(int id)
        {
            var context = _contexto.ExVest.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
        public async Task<IActionResult> ExerciciosEnemFisIndex(int id)
        {
            var context = _contexto.ExVest.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
        public async Task<IActionResult> ExerciciosFuvestFisIndex(int id)
        {
            var context = _contexto.ExVest.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
        public async Task<IActionResult> ExerciciosComvestFisIndex(int id)
        {
            var context = _contexto.ExVest.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
    }
}
