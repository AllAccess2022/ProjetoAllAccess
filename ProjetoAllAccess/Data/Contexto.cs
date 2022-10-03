using Microsoft.EntityFrameworkCore;
using ProjetoAllAccess.Models;

namespace ProjetoAllAccess.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        

        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
