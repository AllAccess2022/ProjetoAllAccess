using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
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
        private readonly IEmail _email;
        public LoginController(IUsuarioRepositorio usuarioRepositorio,
                                ISessao sessao,
                                IEmail email)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
            _email = email;
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
        public IActionResult RedefinirSenha()
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
                            _sessao.CriarSessaoDoUsuario(usuario);
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensagemErro"] = $"Login Não foi realizado, senha inválida!";
                    }
                    TempData["MensagemErro"] = $"Login Não foi realizado, Usuário ou senha inválidos!";

                }
                return View("Login");

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Login não foi realizado: {erro.Message})";
                return RedirectToAction("Login");

            }       

        }

        [HttpPost]
        public IActionResult EnviarLinkParaRedefinirSenha(RedefinirSenhaModel redefinirSenhaModel)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    Usuario usuario = _usuarioRepositorio.BuscarEmailParaRedefinir(redefinirSenhaModel.Email);

                    if (usuario != null)
                    {
                        string novaSenha = usuario.GerarNovaSenha();
                        string mensagem = $"Sua nova senha é: {novaSenha}";
                        _usuarioRepositorio.AtualizarSenha(usuario);
                        bool emailEnviado = _email.Enviar(usuario.Email, "AllAccess - Nova Senha", mensagem);

                        if (emailEnviado)
                        {
                           
                            
                            TempData["MensagemSucesso"] = $"Nova senha enviada por email.";
                        }
                        else
                        {
                            TempData["MensagemErrou"] = $"Ocorreu um Erro.";
                        }
                        
                        return RedirectToAction("Login", "Login");

                    }
                    TempData["MensagemErro"] = $"Não conseguimos redefinir sua senha. Verifique os dados informados.";

                }
                return View("Login");

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possivel redefinir sua senha, tente novamente: {erro.Message})";
                return RedirectToAction("Login");

            }
        }


    }
}

