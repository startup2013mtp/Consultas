using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Framawork
{
    public class Mail
    {
        public static void enviaEmail() {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.Subject = "Solicitação de oramento";
            msg.From = new System.Net.Mail.MailAddress("matheusny2006@gmail.com");
            msg.To.Add(new System.Net.Mail.MailAddress("tizinho29@gmail.com"));
            msg.Body = TemplateHtml.mountEmail();
            msg.IsBodyHtml = true;
            System.Net.Mail.SmtpClient smpt = new System.Net.Mail.SmtpClient();
            smpt.Host = "smtp.gmail.com";
            smpt.Port = 587;
            smpt.EnableSsl = true;
            smpt.Credentials = new System.Net.NetworkCredential("matheusny2006@gmail.com", "gmailchains2013");
            smpt.Send(msg);
        }
        public static void enviaDadosContato(string nome, string email, string mensagem)
        {
            System.Net.Mail.MailMessage msg = new MailMessage();
            msg.Subject = "Dúvida" + nome;
            msg.Body = mensagem;
            msg.From = new MailAddress(email);
            msg.To.Add(new MailAddress("tizinho29@gmail.com"));
            
            System.Net.Mail.SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("matheusny2006@gmail.com", "gmailchains2013");
            smtp.Send(msg);

        }
    }
}
