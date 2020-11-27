using Microsoft.AspNetCore.Mvc;
using RssFeedReader.Api.Models;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;

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

            var feed = formatter.Feed.Items.Select(feedItem =>
                new Feed
                {
                    Title = feedItem.Title.Text,
                    Link = feedItem.Links.First().Uri.ToString()
                }).ToList();

            return Ok(feed);
        }
    }
}