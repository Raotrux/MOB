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
    public partial class MobLibraryPage : ContentPage
    {
        public ObservableCollection<Item> Items { get; set; }
        public string VideoId { get; set; }
        public string VideoTitle { get; set; }
        public string VideoDescription { get; set; }
        public MobLibraryPage()
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
                    string url = videos[index].Url;
                    string thumbnail = "https://img.youtube.com/vi/" + VideoId + "/0.jpg";

                    var video = await youtube.Videos.GetAsync(url);
                    VideoDescription = "Either I load the actual description and it takes forever, or we figure out an alternative for now";

                    Items.Add(new Item() { Id = VideoId, Title = VideoTitle, Thumbnail = thumbnail, Description = VideoDescription });
                }
            };
            DailyDoseVideos.ItemsSource = Items;
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