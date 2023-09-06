using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoAllAccess.Data;
using ProjetoAllAccess.Filters;
using ProjetoAllAccess.Models;
using ProjetoAllAccess.Repositorio;

namespace ProjetoAllAccess.Controllers
{
    
    public class ContaController : Controller
    {
        private readonly Contexto _context;
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public ContaController(Contexto context,
                                IUsuarioRepositorio usuarioRepositorio)
        {
            _context = context;
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult CriarConta()
        {
            return View();
        }
        public IActionResult MudancaSenha()
        {
            return View();
        }
        public async Task<IActionResult> DetalheConta(Guid? id) 
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }
        public IActionResult EditarConta(Guid id)
        {
            Usuario usuario =_usuarioRepositorio.BuscarPorId(id);
            return View(usuario);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CriarConta([Bind("Id,Nome,Sobrenome,Email,Nascimento,Senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Id = Guid.NewGuid();
                _context.Add(usuario);
                usuario.SetSenhaHash();
                await _context.SaveChangesAsync();
                TempData["Mensagem"] = $"Conta criada com sucesso!";
                return RedirectToAction(nameof(CriarConta));
            }
            else
            {
                // Adicione um erro ao ModelState para indicar que houve um problema na validação.
                ModelState.AddModelError(string.Empty, "Erro ao criar a conta. Por favor, verifique os dados inseridos.");

                // Redirecione de volta para a página de criação de conta com os erros.
                return View("CriarConta");
            }
        }
        [HttpPost]

        public IActionResult Alterar(Usuario usuario)
        {
            _usuarioRepositorio.Atualizar(usuario);
            return RedirectToAction("Index","Home");
        }

    }
}
