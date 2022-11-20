using System.Net;
using System.Net.Mail;

namespace ProjetoAllAccess.Helper
{
    public class Email : IEmail
    {
        private readonly IConfiguration _configuration;

        public Email(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool Enviar(string email, string assunto, string mensagem)
        {
            try
            {
                string host = _configuration.GetValue<string>("SMTP:Host");
                string nome = _configuration.GetValue<string>("SMTP:Nome");
                string username = _configuration.GetValue<string>("SMTP:Username");
                string senha = _configuration.GetValue<string>("SMTP:Senha");
                int porta = _configuration.GetValue<int>("SMTP:Porta");

                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(username, nome)
                };

                mail.To.Add(email);
                mail.Subject = assunto;
                mail.Body= mensagem;
                mail.IsBodyHtml= true;
                mail.Priority= MailPriority.High;

                using(SmtpClient smtp = new SmtpClient(host, porta)) 
                {
                    smtp.Credentials = new NetworkCredential(username, senha);
                    smtp.EnableSsl= true;

                    smtp.Send(mail);
                    return true;
                }

            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
