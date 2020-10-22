using System.ServiceModel.Syndication;
using System.Xml;

namespace RssReaderWebService
{
    public class RssReader : IRssReader
    {
        public Rss20FeedFormatter LoadFeedFromUrl(string feedUrl)
        {
            var formatter = new Rss20FeedFormatter();

            using (var xmlReader = XmlReader.Create(feedUrl))
            {
                formatter.ReadFrom(xmlReader);
            }

            return formatter;
        }
    }
}