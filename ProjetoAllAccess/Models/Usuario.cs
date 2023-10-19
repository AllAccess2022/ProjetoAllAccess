using ProjetoAllAccess.Helper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAllAccess.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Insira seu nome")]
        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Insira seu sobrenome")]
        [Display(Name = "Sobrenome")]
        [Column("Sobrenome")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Insira seu E-mail")]
        [EmailAddress(ErrorMessage = "E-mail Inválido!")]
        [Display(Name = "E-mail")]
        [Column("Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Insira sua data de Nascimento")]
        [Display(Name = "Data de nascimento")]
        [Column("Nascimento")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
        [Required(ErrorMessage = "Insira Nivel")]
        [Display(Name = "Nivel")]
        [Column("Nivel")]
        public int Nivel { get; set; }
        [Required(ErrorMessage = "Insira sua senha")]
        [Display(Name = "Senha")]
        [Column("Senha")]
        public string Senha { get; set; }

        public bool SenhaValida(string senha)
        {
            return Senha == senha.GerarHash();
        }

        public void SetSenhaHash()
        {
            Senha = Senha.GerarHash();
        }

        public string GerarNovaSenha()
        {
            string novaSenha = Guid.NewGuid().ToString().Substring(0, 8);
            Senha = novaSenha.GerarHash();
            return novaSenha;
        }

    }
}
