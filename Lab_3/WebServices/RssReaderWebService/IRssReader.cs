using System.ServiceModel;
using System.ServiceModel.Syndication;

namespace RssReaderWebService
{
    [ServiceContract]
    public interface IRssReader
    {
        [OperationContract]
        Rss20FeedFormatter LoadFeedFromUrl(string feedUrl);
    }
}