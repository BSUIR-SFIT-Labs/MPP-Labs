using RssFeedReaderLib;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace RssFeedReader
{
    public partial class MainWindow : Window
    {
        private readonly List<string> _tags;
        private readonly List<string> _recipients;

        private Timer _timer;
        private long _scheduleTime;

        public MainWindow()
        {
            InitializeComponent();

            _tags = new List<string>();
            _recipients = new List<string>();
        }

        public long ScheduleTime
        {
            get => _scheduleTime;
            set
            {
                _scheduleTime = value;
                _timer?.Change(0, _scheduleTime);
            }
        }

        private void BtnGetFeed_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button getFeedButton)
            {
                if (getFeedButton.Content != null
                    && (string) getFeedButton.Content == "Start getting RSS feed")
                {
                    if (!string.IsNullOrWhiteSpace(TbTags.Text))
                    {
                        _tags.AddRange(TbTags.Text.Split(';'));
                    }
                    if (!string.IsNullOrWhiteSpace(TbRecipients.Text))
                    {
                        _recipients.AddRange(TbRecipients.Text.Split(';'));
                    }

                    _timer = new Timer(TimerCallback, null, 0, _scheduleTime);
                    StartGettingFeedPreparation();
                }
                else
                {
                    _timer?.Dispose();
                    StopGettingFeedPreparation();
                }
            }
        }

        private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                ScheduleTime = Convert.ToInt64(radioButton.Tag);
            }
        }

        private void TimerCallback(object o)
        {
            FeedContent.Dispatcher.BeginInvoke(
                new Action(() => FeedContent.DataContext =
                    RssFeedLoader.StartPollingRssSourcesOnSchedule(TbFeedUrl.Text, _tags, _recipients)));
        }

        private void StartGettingFeedPreparation()
        {
            BtnGetFeed.Content = "Stop getting RSS feed";

            TbFeedUrl.IsEnabled = false;
            TbTags.IsEnabled = false;
            TbRecipients.IsEnabled = false;
            Rbtn1Min.IsEnabled = false;
            Rbtn5Min.IsEnabled = false;
            Rbtn30Min.IsEnabled = false;
            Rbtn1Hour.IsEnabled = false;
            Rbtn2Hour.IsEnabled = false;
        }

        private void StopGettingFeedPreparation()
        {
            BtnGetFeed.Content = "Start getting RSS feed";

            LbFeedItems.DataContext = null;
            FrameFeedContent.Source = null;

            TbFeedUrl.IsEnabled = true;
            TbTags.IsEnabled = true;
            TbRecipients.IsEnabled = true;
            Rbtn1Min.IsEnabled = true;
            Rbtn5Min.IsEnabled = true;
            Rbtn30Min.IsEnabled = true;
            Rbtn1Hour.IsEnabled = true;
            Rbtn2Hour.IsEnabled = true;
        }
    }
}