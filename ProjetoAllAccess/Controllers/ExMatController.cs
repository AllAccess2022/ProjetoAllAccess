using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAllAccess.Data;

namespace ProjetoAllAccess.Controllers
{
    public class ExMatController : Controller
    {
        private readonly Contexto _contexto;

        public ExMatController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task <IActionResult> ExercicioMatIndex(int id)
        {
            var context = _contexto.Exercicio.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }
       
    }
}
