using Mob.Models;
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
    public partial class ThreeMinMobPage : ContentPage
    {
        public ThreeMinMobPage()
        {
            InitializeComponent();
            GetVideoContent();
        }

        private async void GetVideoContent()
        {
            var youtube = new YoutubeClient();
            string videoId = "F13du3MHfJY";
            var videoURL = $"https://www.youtube.com/watch?v={videoId}";
            var video = await youtube.Videos.GetAsync(videoURL);

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoURL);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            if (streamInfo != null)
            {
                // Get the actual stream
                // var stream = await youtube.Videos.Streams.GetAsync(streamInfo);

                // Then use it with MediaElement
                videoSource.Source = streamInfo.Url;
            }
        }
    }
}