using System.Collections.Generic;
using System.Xml.Serialization;

namespace RssFeedFilter.Api.Models
{
    [XmlRoot(Namespace = "http://schemas.datacontract.org/2004/07/RssFeedReader.Api.Models")]
    public class FeedItemList
    {
        public FeedItemList()
        {
            Items = new List<FeedItem>();
        }

        public List<FeedItem> Items { get; set; }
    }
}