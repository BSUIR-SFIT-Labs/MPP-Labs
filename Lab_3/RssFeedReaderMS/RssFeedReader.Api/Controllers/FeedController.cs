using System.IO;
using Microsoft.AspNetCore.Mvc;
using RssFeedReader.Api.Models;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.OpenApi.Extensions;

namespace RssFeedReader.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FeedController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetFeed(string feedUrl)
        {
            var formatter = new Rss20FeedFormatter();

            using var reader = XmlReader.Create(feedUrl);
            formatter.ReadFrom(reader);

            var feedItemList = new FeedItemList();

            foreach (var feedItem in formatter.Feed.Items)
            {
                feedItemList.Items.Add(new FeedItem
                {
                    Title = feedItem.Title.Text,
                    Link = feedItem.Links.First().Uri.ToString(),
                    Summary = feedItem.Summary.Text
                });
            }

            return Ok(feedItemList);
        }
    }
}