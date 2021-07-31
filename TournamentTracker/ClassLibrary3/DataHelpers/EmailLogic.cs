using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Configuration;

namespace ClassLibrary3.DataHelpers
{
    public static class EmailLogic
    {
        public static void SendEmail(string to, string subject, string body)
        {
            MailAddress fromMail = new MailAddress(ConfigurationManager.AppSettings["senderEmail"], ConfigurationManager.AppSettings["senderDisplayName"]);

            MailMessage mail = new MailMessage();

            mail.To.Add(to);
            mail.From = fromMail;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();

            client.Send(mail);
        }
    }
}
