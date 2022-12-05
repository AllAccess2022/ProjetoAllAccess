namespace ProjetoAllAccess.Models
{
    public class PostUserModel
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Materia { get; set; }
        public string Conteudo { get; set;}
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
    }
}
