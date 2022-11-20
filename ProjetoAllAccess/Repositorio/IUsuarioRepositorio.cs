using ProjetoAllAccess.Models;

namespace ProjetoAllAccess.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Usuario BuscarPorEmail(string email);

        Usuario BuscarEmailParaRedefinir(string email);

        Usuario BuscarPorId(Guid id);

        Usuario AtualizarSenha(Usuario usuario);

        Usuario Atualizar(Usuario usuario);
    }
}
