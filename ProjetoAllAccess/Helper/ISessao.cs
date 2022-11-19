using ProjetoAllAccess.Models;

namespace ProjetoAllAccess.Helper
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(Usuario usuario);
        void RemoverSessaoUsuario();
        Usuario BuscarSessaoDoUsuario();

    }
}
