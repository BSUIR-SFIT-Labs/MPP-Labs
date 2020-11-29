using Microsoft.AspNetCore.Mvc;
using RssFeedEmailSender.Api.Models.Feed;
using RssFeedEmailSender.Api.Models.Mail;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace RssFeedEmailSender.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FeedEmailSender : ControllerBase
    {
        [HttpGet]
        public IActionResult SendEmail(string feedUrl, string tags, string recipients)
        {
            var request = (HttpWebRequest)WebRequest.Create($"https://localhost:44380/api/v1/feedfilter?feedUrl={feedUrl}&tags={tags}");
            request.Accept = "application/xml";

            var response = request.GetResponse();

            using var streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

            var xmlSerializer = new XmlSerializer(typeof(FeedItemList));
            var feedItemList = (FeedItemList)xmlSerializer.Deserialize(new StringReader(streamReader.ReadToEnd()));

            var listOfRecipients = recipients?.Split(';');

            if (recipients != null && recipients.Any())
            {
                foreach (string recipient in listOfRecipients)
                {
                    MailService.SendEmailAsync(recipient, MailService.RssFeedToString(feedItemList));
                }
            }

            return Ok();
        }
    }
}
