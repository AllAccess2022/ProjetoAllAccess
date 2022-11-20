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

        public Usuario BuscarEmailParaRedefinir(string email)
        {
            return _context.Usuario.FirstOrDefault(x => x.Email == email);
        }

        public Usuario BuscarPorEmail(string email)
        {
            return _context.Usuario.FirstOrDefault(x => x.Email == email);
        }
        public Usuario BuscarPorId(Guid id)
                {
            return _context.Usuario.FirstOrDefault(x => x.Id == id);
                }
        public Usuario AtualizarSenha(Usuario usuario)
        {
            Usuario usuarioDB = BuscarPorId(usuario.Id);
            if (usuarioDB != null) throw new System.Exception("Erro");

            usuarioDB.Senha = usuario.Senha;

            _context.Usuario.Update(usuarioDB);
            _context.SaveChanges();

            return usuarioDB;
        }

        public Usuario Atualizar(Usuario usuario)
        {
            Usuario usuarioDB = BuscarPorId(usuario.Id);
            if (usuarioDB == null) throw new System.Exception("Erro");

            usuarioDB.Nome = usuario.Nome;
            usuarioDB.Sobrenome = usuarioDB.Sobrenome;
            usuarioDB.Email= usuario.Email;

            _context.Usuario.Update(usuarioDB);
            _context.SaveChanges();

            return usuarioDB;
        }
    }
}
