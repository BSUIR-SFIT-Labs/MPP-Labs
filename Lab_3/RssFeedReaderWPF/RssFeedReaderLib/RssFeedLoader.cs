using System.Collections.Generic;
using System.Linq;
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

        public static Rss20FeedFormatter FilterFeedByTags(Rss20FeedFormatter rssFeedFormatter,
            IEnumerable<string> tags)
        {
            var feed = new SyndicationFeed
            {
                Title = new TextSyndicationContent("Filtered feed")
            };

            var resultRssFeedFormatter = new Rss20FeedFormatter(feed);
            resultRssFeedFormatter.Feed.Items = FilterItemsInFeedByTags(rssFeedFormatter.Feed.Items, tags);

            return resultRssFeedFormatter;
        }

        private static IEnumerable<SyndicationItem> FilterItemsInFeedByTags(IEnumerable<SyndicationItem> feedItems,
            IEnumerable<string> tags)
        {
            var filteredListOfRssItems = new List<SyndicationItem>();

            var listOfTags = tags.ToList();

            if (listOfTags.Any())
            {
                filteredListOfRssItems.AddRange(feedItems.Where(rssFeedItem =>
                    listOfTags.Any(tag =>
                        rssFeedItem.Summary.Text.ToUpper().Contains(tag.ToUpper()))));

                return filteredListOfRssItems;
            }

            return feedItems.ToList();
        }
    }
}