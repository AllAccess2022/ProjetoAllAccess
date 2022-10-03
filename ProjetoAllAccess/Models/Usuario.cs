using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace ProjetoAllAccess.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Insira Nome")]
        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Insira Sobrenome")]
        [Display(Name = "Sobrenome")]
        [Column("Sobrenome")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Insira Email")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        [Display(Name = "Email")]
        [Column("Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Insira Data Nascimento")]
        [Display(Name = "Data Nascimento")]
        [Column("Nascimento")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
        [Required(ErrorMessage = "Insira Nivel")]
        [Display(Name = "Nivel")]
        [Column("Nivel")]
        public int Nivel { get; set; }
        [Required(ErrorMessage = "Insira Senha")]
        [Display(Name = "Senha")]
        [Column("Senha")]
        public string Senha { get; set; }

        public bool SenhaValida(string senha) 
        {
            return Senha == senha;
        }
    }
}
