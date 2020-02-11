using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            // SMTP -> Servidor que vai enviar a mensagem
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // Porta 587 tem protocolo de segurança TLS (Transport Layer Security)
            // Conferir: https://support.google.com/a/answer/176600?hl=pt-BR
            smtp.UseDefaultCredentials = false; // Aqui eu defino que não vou utilizar credenciais padrão
            smtp.Credentials = new NetworkCredential("fbaroni1992@gmail.com", "gmail@fbaroni1992"); // Aqui eu defino minhas credenciais
            smtp.EnableSsl = true; // Serve para TLS também (?)

            string corpoMsg = string.Format(
                "<h2>Contato LojaVirtual</h2>" +
                "<b>Nome: </b> {0} <br />" +
                "<b>Email: </b> {1} <br />" +
                "<b>Texto: </b> {2} <br />" +
                "<br />E-mail enviado automaticamente do site da LojaVirtual.", contato.Nome, contato.Email, contato.Texto
                );

            // MailMessage -> Constrói a mensagem que será enviada
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("fbaroni1992@gmail.com");
            mensagem.To.Add("stefano.tejo@gmail.com");
            mensagem.To.Add("stefano@pbhub.com.br");
            mensagem.Subject = "Contato - LojaVirtual - E-mail: " + contato.Email;
            mensagem.IsBodyHtml = true;
            mensagem.Body = corpoMsg;

            smtp.Send(mensagem);
        }
    }
}
