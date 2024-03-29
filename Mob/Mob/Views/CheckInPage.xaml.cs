﻿using Mob.Models;
using Mob.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos.Streams;

namespace Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckInPage : ContentPage
    {
        public CheckInPage()
        {
            InitializeComponent();
            GetVideoContent();
        }

        private async void GetVideoContent()
        {
            var youtube = new YoutubeClient();
            string videoId = "1Swsp-IoGv0";
            var videoURL = $"https://www.youtube.com/watch?v={videoId}";
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoURL);
            
            if (streamManifest != null)
            {
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                if (streamInfo != null)
                {
                    // Get the actual stream
                    //var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                    //videoKeywords.Text = stream.Keywords;
                    // videoDuration.Text = stream.Length;

                    // Then use it with MediaElement
                    videoSource.Source = streamInfo.Url;
                }
            }
        }
    }
}