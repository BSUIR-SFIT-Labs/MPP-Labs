using System.Collections.Generic;
using System.Xml.Serialization;

namespace RssFeedReader.Data.Feed
{
    [XmlRoot(Namespace = "http://schemas.datacontract.org/2004/07/RssFeedFilter.Api.Models")]
    public class FeedItemList
    {
        public FeedItemList()
        {
            Items = new List<FeedItem>();
        }

        public List<FeedItem> Items { get; set; }
    }
}