using Microsoft.AspNetCore.Mvc;
using ProjetoAllAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace ProjetoAllAccess.Controllers
{
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
        public async Task<IActionResult> ExerciciosVestibularIndex(int id)
        {
            var context = _contexto.ExVest.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
    }
}
