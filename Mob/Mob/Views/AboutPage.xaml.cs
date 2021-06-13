using System;
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
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            GetVideoContent();
        }

        private async void GetVideoContent()
        {
            var youtube = new YoutubeClient();
            string videoId = "9vN_LL98BnU";
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