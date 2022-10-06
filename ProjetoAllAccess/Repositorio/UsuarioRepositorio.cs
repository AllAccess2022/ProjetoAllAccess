using ProjetoAllAccess.Data;
using ProjetoAllAccess.Models;

namespace ProjetoAllAccess.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly Contexto _context;

        public UsuarioRepositorio(Contexto context)
        {
            this._context = context;
        }

        public Usuario BuscarPorEmail(string email)
        {
            return _context.Usuario.FirstOrDefault(x => x.Email == email);
        }
    }
}
