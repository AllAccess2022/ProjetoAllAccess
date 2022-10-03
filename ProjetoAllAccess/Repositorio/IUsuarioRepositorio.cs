using ProjetoAllAccess.Models;

namespace ProjetoAllAccess.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Usuario BuscarPorEmail(string email);
    }
}
