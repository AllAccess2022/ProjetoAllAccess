using Microsoft.AspNetCore.Mvc;
using ProjetoAllAccess.Data;
using ProjetoAllAccess.Models;

namespace ProjetoAllAccess.Controllers
{
    public class ContaController : Controller
    {
        private readonly Contexto _context;

        public ContaController(Contexto context)
        {
            _context = context;
        }
        public IActionResult CriarConta()
        {
            return View();
        }
        public IActionResult DetalheConta() 
        {
            return View();
        }
        public IActionResult EditarConta()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CriarConta([Bind("Id,Nome,Sobrenome,Email,Nascimento,Senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Id = Guid.NewGuid();
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                TempData["Mensagem"] = $"Conta criada com sucesso!";
                return RedirectToAction(nameof(CriarConta));
            }
            return View("Home","Login");
        }
    }
}
