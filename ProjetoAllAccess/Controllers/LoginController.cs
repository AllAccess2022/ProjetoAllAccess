using Microsoft.AspNetCore.Mvc;
using ProjetoAllAccess.Models;
using ProjetoAllAccess.Repositorio;

namespace ProjetoAllAccess.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CriarConta()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    Usuario usuario = _usuarioRepositorio.BuscarPorEmail(loginModel.Login);

                    if (usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensagemErro"] = $"Login Não foi realizado, senha invalida";
                    }
                    TempData["MensagemErro"] = $"Login Não foi realizado, Usuario ou senha invalidos";

                }
                return View("Index");

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Login Não foi realizado: {erro.Message})";
                return RedirectToAction("Index");

            }

        }

    }
}

