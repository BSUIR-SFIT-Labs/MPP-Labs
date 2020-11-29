using System.Collections.Generic;

namespace RssFeedReader.Api.Models
{
    public class FeedItemList
    {
        public FeedItemList()
        {
            Items = new List<FeedItem>();
        }

        public List<FeedItem> Items { get; set; }
    }
}
