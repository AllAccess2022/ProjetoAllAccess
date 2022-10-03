using Microsoft.EntityFrameworkCore.Metadata;
using ProjetoAllAccess.Data;
using ProjetoAllAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
