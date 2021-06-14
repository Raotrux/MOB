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
    public partial class DailyDosePage : ContentPage
    {
        public DailyDosePage()
        {
            InitializeComponent();
            GetVideoContent();
        }

        private async void GetVideoContent()
        {
            var youtube = new YoutubeClient();
            string videoId = "VHcIX1KcDmA";
            var videoURL = $"https://www.youtube.com/watch?v={videoId}";
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
                    videoDescription.Text = "Designed to get your body ready for whatever the day has in store! For an abbreviated version, try the 3-Min Mob as a quick warm-up for cool-down! No sweat, no equipment necessary. Note: Mobilizations during this routine should NOT be painful. Only stretch to tolerance. Your tolerance may vary depending on the state of the tissue. As always, be sure to consult the appropriate member of your healthcare team if you notice pain. ";
                }
            }
        }
    }
}