using RssFeedReaderLib;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;

namespace RssFeedReader
{
    public partial class MainWindow : Window
    {
        private Timer _timer;
        private long _scheduleTime;

        public MainWindow()
        {
            InitializeComponent();

            _scheduleTime = 10000;
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

        private void OnGetFeed(object sender, RoutedEventArgs e)
        {
            _timer = new Timer(Test, null, 0, _scheduleTime);
        }

        private void Test(object o)
        {
            feedContent.Dispatcher.BeginInvoke(
                new Action(() => feedContent.DataContext =
                    RssFeedLoader.StartPollingRssSourcesOnSchedule(textUrl.Text, new List<string>())));
        }
    }
}