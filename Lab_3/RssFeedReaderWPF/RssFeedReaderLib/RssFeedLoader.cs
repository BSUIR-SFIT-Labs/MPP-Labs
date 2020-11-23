using RssFeedReaderLib.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Threading;
using System.Xml;

namespace RssFeedReaderLib
{
    public static class RssFeedLoader
    {
        public static IEnumerable<SyndicationItem> StartPollingRssSourcesOnSchedule(string feedUrl,
            IEnumerable<string> tags, IEnumerable<string> recipients)
        {
            var waitHandle = new ManualResetEvent(false);
            SyndicationFeedFormatter formatter = null;

            ThreadPool.QueueUserWorkItem(state =>
            {
                formatter = FilterFeedByTags(LoadFeedFromUrl(feedUrl), tags);
                waitHandle.Set();
            });

            waitHandle.WaitOne();

            ThreadPool.QueueUserWorkItem(state => SendFeedToRecipients(recipients, formatter));

            return formatter.Feed.Items;
        }

        private static Rss20FeedFormatter LoadFeedFromUrl(string feedUrl)
        {
            var rssFeedFormatter = new Rss20FeedFormatter();

            using var xmlReader = XmlReader.Create(feedUrl);
            rssFeedFormatter.ReadFrom(xmlReader);

            return rssFeedFormatter;
        }

        private static Rss20FeedFormatter FilterFeedByTags(SyndicationFeedFormatter rssFeedFormatter,
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

        private static void SendFeedToRecipients(IEnumerable<string> recipients,
            SyndicationFeedFormatter rssFeedFormatter)
        {
            foreach (string recipient in recipients)
            {
                MailService.SendEmailAsync(recipient, RssFeedToString(rssFeedFormatter.Feed.Items));
            }
        }

        private static string RssFeedToString(IEnumerable<SyndicationItem> feeItems)
        {
            return feeItems.Aggregate(string.Empty, (current, feedItem) =>
                current + feedItem.Title.Text + " " + feedItem.Links.First().Uri + Environment.NewLine);
        }
    }
}