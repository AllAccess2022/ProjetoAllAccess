using System.ComponentModel.DataAnnotations;

namespace ProjetoAllAccess.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Insira Email")]
        public string Email { get; set; }
    }
}
