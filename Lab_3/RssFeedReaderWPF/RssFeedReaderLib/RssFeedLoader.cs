using System.ServiceModel.Syndication;
using System.Xml;

namespace RssFeedReaderLib
{
    public class RssFeedLoader
    {
        public static Rss20FeedFormatter LoadFeedFromUrl(string feedUrl)
        {
            var rssFeedFormatter = new Rss20FeedFormatter();

            using var xmlReader = XmlReader.Create(feedUrl);
            rssFeedFormatter.ReadFrom(xmlReader);

            return rssFeedFormatter;
        }
    }
}