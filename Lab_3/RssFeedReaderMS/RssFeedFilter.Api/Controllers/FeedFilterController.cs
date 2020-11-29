using Microsoft.AspNetCore.Mvc;
using RssFeedFilter.Api.Models;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace RssFeedFilter.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FeedFilterController : ControllerBase
    {
        public IActionResult GetFilteredFeed(string feedUrl, string tags)
        {
            var request = (HttpWebRequest)WebRequest.Create($"https://localhost:44352/api/v1/feed?feedUrl={feedUrl}");
            request.Accept = "application/xml";

            var response = request.GetResponse();

            using var streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

            var xmlSerializer = new XmlSerializer(typeof(FeedItemList));
            var feedItemList = (FeedItemList)xmlSerializer.Deserialize(new StringReader(streamReader.ReadToEnd()));

            var listOfTags = tags?.Split(';');

            var filteredFeedItemList = new FeedItemList();

            if (listOfTags != null && listOfTags.Any())
            {
                if (feedItemList != null)
                {
                    foreach (var feedItem in feedItemList.Items.Where(feedItem =>
                        listOfTags.Any(tag => feedItem.Summary.ToUpper().Contains(tag.ToUpper()))))
                    {
                        filteredFeedItemList.Items.Add(feedItem);
                    }
                }

                return Ok(filteredFeedItemList);
            }

            return Ok(feedItemList);
        }
    }
}