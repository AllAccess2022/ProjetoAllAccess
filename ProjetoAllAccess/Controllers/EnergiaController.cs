using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAllAccess.Data;
using System;

namespace ProjetoAllAccess.Controllers
{
    public class EnergiaController : Controller
    {
        private readonly Contexto _contexto;

        public EnergiaController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            var apsContext = _contexto.Conteudos.Where(p => p.Materia.Equals("Física") && p.Assunto.Equals("Energia"));
            return View(await apsContext.ToListAsync());
        }
    }
}
