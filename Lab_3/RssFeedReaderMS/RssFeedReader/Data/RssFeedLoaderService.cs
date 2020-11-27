using RssFeedReader.Data.Feed;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RssFeedReader.Data
{
    public class RssFeedLoaderService
    {
        public Task<FeedItemList> StartPollingRssSourcesOnSchedule(string feedUrl, string tags, string recipients)
        {
            var waitHandle = new ManualResetEvent(false);
            FeedItemList feedItemList = null;

            ThreadPool.QueueUserWorkItem(state =>
            {
                feedItemList = GetFeedItemList(feedUrl, tags).Result;
                waitHandle.Set();
            });

            waitHandle.WaitOne();

            ThreadPool.QueueUserWorkItem(state =>
                SendFeedToRecipients(feedUrl, tags, recipients));

            return Task.FromResult(feedItemList);
        }

        private Task<FeedItemList> GetFeedItemList(string feedUrl, string tags)
        {
            var request = (HttpWebRequest)WebRequest.Create(
                $"https://localhost:44380/api/v1/feedfilter?feedUrl={feedUrl}&tags={tags}");
            request.Accept = "application/xml";

            var response = request.GetResponse();

            using var streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

            var xmlSerializer = new XmlSerializer(typeof(FeedItemList));
            var feedItemList = (FeedItemList)xmlSerializer.Deserialize(new StringReader(streamReader.ReadToEnd()));

            return Task.FromResult(feedItemList);
        }

        private Task<bool> SendFeedToRecipients(string feedUrl, string tags, string recipients)
        {
            var request = (HttpWebRequest)WebRequest.Create(
                $"https://localhost:44361/api/v1/feedemailsender?feedUrl={feedUrl}&tags={tags}&recipients={recipients}");

            var response = (HttpWebResponse)request.GetResponse();
            return Task.FromResult(response.StatusCode == HttpStatusCode.OK);
        }
    }
}