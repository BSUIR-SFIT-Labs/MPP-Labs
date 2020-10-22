using RssReader.RssReaderServiceReference;
using System.Windows;

namespace RssReader
{
    public partial class MainWindow
    {
        private readonly RssReaderClient _rssReaderClient = new RssReaderClient(); 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnGetFeed(object sender, RoutedEventArgs e)
        {
            var formatter = _rssReaderClient.LoadFeedFromUrl(textUrl.Text);

            DataContext = formatter.Feed;
            feedContent.DataContext = formatter.Feed.Items;
        }
    }
}