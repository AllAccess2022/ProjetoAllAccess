namespace ProjetoAllAccess.Helper
{
    public interface IEmail
    {
        bool Enviar(string email, string asunto, string mensagem);
    }
}
