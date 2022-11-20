using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAllAccess.Data;
using ProjetoAllAccess.Filters;

namespace ProjetoAllAccess.Controllers
{
    [PaginaParaUsuarioLogado]
    public class ExFisController : Controller
    {
        private readonly Contexto _contexto;

        public ExFisController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> ExercicioFisIndex(int id)
        {
            var context = _contexto.Exercicio.Where(p => p.Id.Equals(id));
            return View(await context.ToListAsync());
        }       
    }
}
