using RssFeedEmailSender.Api.Models.Feed;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace RssFeedEmailSender.Api.Models.Mail
{
    public class MailService
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

        public static string RssFeedToString(FeedItemList feeItemList)
        {
            return feeItemList.Items.Aggregate(string.Empty, 
                (current, feedItem) =>
                    current + (feedItem.Title + " " + feedItem.Link + Environment.NewLine));
        }
    }
}