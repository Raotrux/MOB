﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoPage : ContentPage
    {
        public string VideoTitle { get; set; }
        public string VideoId { get; set; }
        public string VideoDescription { get; set; }

        public VideoPage(string videoId, string videoTitle, string testDescription)
        {
            InitializeComponent();
            VideoId = videoId;
            VideoTitle = videoTitle;
            VideoDescription = "";
            GetVideoContent();
        }
        private async void GetVideoContent()
        {
            var youtube = new YoutubeClient();
            var videoURL = $"https://www.youtube.com/watch?v={VideoId}";
            var video = await youtube.Videos.GetAsync(videoURL);
            var duration = video.Duration;
            VideoDescription = video.Description;

            var keywordData = video.Keywords;
            List<string> keywordList = new List<string>();
            foreach (var word in keywordData)
            {
                keywordList.Add(word);
            }
            var keywords = string.Join(", ", keywordList.ToArray());

            

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoURL);
           
            if (streamManifest != null)
            {
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

                if (streamInfo != null)
                {
                    // Get the actual stream
                    // var stream = await youtube.Videos.Streams.GetAsync(streamInfo);

                    // Then use it with MediaElement
                    videoSource.Source = streamInfo.Url;
                    videoTitle.Text = VideoTitle;
                    videoDescription.Text = VideoDescription;
                    videoDuration.Text = duration.ToString();
                    //videoKeywords.Text = keywords.ToString();
                }
            }
        }
    }
}

/*
private async void GetVideo()
        {
            var youtube = new YoutubeClient();

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(VideoId);

            string thumbnail = "https://img.youtube.com/vi/" + VideoId + "/0.jpg";
            
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            mediaElement.Source = streamInfo;
        }
    }
}
*/