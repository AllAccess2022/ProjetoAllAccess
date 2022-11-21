using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAllAccess.Data;
using ProjetoAllAccess.Models;
using ProjetoAllAccess.Repositorio;

namespace ProjetoAllAccess.Controllers
{
    public class PostUserController : Controller
    {
        private readonly IPostUserRepositorio _PostUserRepositorio;

        public PostUserController(IPostUserRepositorio postUserRepositorio
                                   ,Contexto context)
        {
            _PostUserRepositorio = postUserRepositorio;
            _context = context;
        }
        private readonly Contexto _context;

    
        public async Task<IActionResult> Index()
        {
            return View(await _context.PostUser.ToListAsync());
        }

        public async Task<IActionResult> PostConteudo(int id)
        {
            var context = _context.PostUser.Where(p => p.Id.Equals(id)).OrderBy(x => x.Materia);
            return View(await context.ToListAsync());
        }
        public IActionResult CriarPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(PostUserModel postUser)
        {
            _PostUserRepositorio.Adicionar(postUser);

            return RedirectToAction("Index");
        }
    }
}
