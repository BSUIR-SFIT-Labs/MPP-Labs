using System;
using System.Net;
using System.Net.Mail;

namespace RssFeedReaderLib.Mail
{
    internal static class MailService
    {
        public static void SendEmailAsync(string recipient, string messageBody)
        {
            var fromEmail = new MailAddress(MailConstants.EmailFrom);
            var toEmail = new MailAddress(recipient);

            var mailMessage = new MailMessage(fromEmail, toEmail)
            {
                Subject = $"RSS feed {DateTime.Now}",
                Body = messageBody
            };

            var smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(MailConstants.EmailFrom, MailConstants.EmailFromPassword),
                EnableSsl = true
            };

            smtpClient.Send(mailMessage);
        }
    }
}