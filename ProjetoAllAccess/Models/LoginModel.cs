using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace ProjetoAllAccess.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Insira Email")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Insira Senha")]
        public string Senha { get; set; }
    }
}
