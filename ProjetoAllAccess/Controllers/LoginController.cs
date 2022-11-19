using Microsoft.AspNetCore.Mvc;
using ProjetoAllAccess.Data;
using ProjetoAllAccess.Helper;
using ProjetoAllAccess.Models;
using ProjetoAllAccess.Repositorio;

namespace ProjetoAllAccess.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio? _usuarioRepositorio;
        private readonly ISessao _sessao;
        public LoginController(IUsuarioRepositorio usuarioRepositorio,
                                ISessao sessao)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
        }
  

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            if(_sessao.BuscarSessaoDoUsuario() !=null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult Logout()
        {
            _sessao.RemoverSessaoUsuario();

            return RedirectToAction("Index", "Login");
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
                            _sessao.CriarSessaoDoUsuario(usuario);
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensagemErro"] = $"Login Não foi realizado, senha invalida";
                    }
                    TempData["MensagemErro"] = $"Login Não foi realizado, Usuario ou senha invalidos";

                }
                return View("Login");

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Login Não foi realizado: {erro.Message})";
                return RedirectToAction("Login");

            }       

        }
        

    }
}

