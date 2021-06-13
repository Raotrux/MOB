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

namespace Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SinglesPage : ContentPage
    {
        public ObservableCollection<Item> Items { get; set; }
        public string VideoId { get; set; }
        public string VideoTitle { get; set; }
        public string VideoDescription { get; set; }
        public SinglesPage()
        {
            InitializeComponent();
            BindingContext = this;
            CreateVideosFromPlaylist();
        }
        private async void CreateVideosFromPlaylist()
        {
            var youtube = new YoutubeClient();
            string playlistId = "PLu3icofvKrbm3qZ1cUDjWmccoARuj4Iq8";

            var videos = await youtube.Playlists.GetVideosAsync(playlistId);


            Items = new ObservableCollection<Item>();
            {

                for (int index = 0; index < videos.Count; index++)
                {
                    VideoTitle = videos[index].Title;
                    VideoId = videos[index].Id;
                    string thumbnail = "https://img.youtube.com/vi/" + VideoId + "/0.jpg";
                    

                    //Hamstring PNF
                    if (VideoId == "1py3xlirciQ")
                    {
                        VideoDescription = "Hamstring PNF | 3x10 second holds 1.Begin seated with legs out in front 2.Bring your chest in 3.Reach out your arms 4.Take a big breath 5.Exhale and reach a little farther 6.Slowly tuck your chin towards your chest 7.Begin pressing legs firmly into floor";
                    }
                    //Openers & Positional Breath
                    else if (VideoId == "6B5ysNYiBDE")
                    {
                        VideoDescription = "Openers and Positional Breathing are great ways to restore myofascial balance around our body, allowing you to break past stubborn tightness easily with a few simple breaths. Note: 3 Deep Breaths per position 1.Brügger's w/ Belly Breath 2.Brügger's w/ Chest Breath 3.Lateral Rib Excursion 4.Chest Openers 5.Side Openers 6.Cobra w / Belly Breath 7.Posterior Pelvic Tilts w / Belly Breath";
                    }
                    //Neck PNF
                    else if (VideoId == "-GG4Jyo9xgw")
                    {
                        VideoDescription = "This is a placeholder description for any video's that arent properly displaying their specific description text.";
                    }
                    //Calf PNF
                    else if (VideoId == "NQsxftizTCQ")
                    {
                        VideoDescription = "This is a placeholder description for any video's that arent properly displaying their specific description text.";
                    }
                    //Glute PNF
                    else if (VideoId == "eOfTf5f2lAY")
                    {
                        VideoDescription = "This is a placeholder description for any video's that arent properly displaying their specific description text.";
                    }
                    //Abductor PNF
                    else if (VideoId == "XsdyMPX63ps")
                    {
                        VideoDescription = "This is a placeholder description for any video's that arent properly displaying their specific description text.";
                    }
                    //Quad PNF
                    else if (VideoId == "PTq06-acwEE")
                    {
                        VideoDescription = "This is a placeholder description for any video's that arent properly displaying their specific description text.";
                    }
                    //Default description
                    else
                    {
                        VideoDescription = "This is a placeholder description for any video's that arent properly displaying their specific description text.";
                    }

                    Items.Add(new Item() { Id = VideoId, Title = VideoTitle, Thumbnail = thumbnail, Description = VideoDescription });
                }
            };
            SinglesVideos.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var message = (Item)e.Item;
            var id = message.Id;
            var title = message.Title;
            var description = message.Description;

            await Shell.Current.Navigation.PushAsync(new VideoPage(id, title, description));

            //await DisplayAlert("Item Tapped", "An item was tapped." + test1 + "/" + test2 + "/" + test3, "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}