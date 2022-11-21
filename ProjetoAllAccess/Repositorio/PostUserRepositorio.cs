using ProjetoAllAccess.Data;
using ProjetoAllAccess.Models;
using System.Security.Policy;

namespace ProjetoAllAccess.Repositorio
{ 

    public class PostUserRepositorio : IPostUserRepositorio
    {
        private readonly Contexto _contexto;

        public PostUserRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public PostUserModel Adicionar(PostUserModel postUser)
        {
            _contexto.PostUser.Add(postUser);
            _contexto.SaveChanges();

            return postUser;
        }
    }
}
