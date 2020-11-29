using System.ComponentModel.DataAnnotations;

namespace RssFeedReader.Data.Models
{
    public class FeedReceivingModel
    {
        [Required]
        public string Url { get; set; }

        public string Tags { get; set; }

        public string Recipients { get; set; }
    }
}