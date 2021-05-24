using MobTestApp.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YoutubeExplode;
using YoutubeExplode.Common;

namespace MobTestApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ObservableCollection<Item> Items { get; set; }

        public ListViewPage()
        {
            InitializeComponent();
            BindingContext = this;

            CreateVideosFromPlaylist();
        }

        private async void CreateVideosFromPlaylist()
        {
            var youtube = new YoutubeClient();
            string playlistId = "FLFwMITSkc1Fms6PoJoh1OUQ";

            var videos = await youtube.Playlists.GetVideosAsync(playlistId);


            Items = new ObservableCollection<Item>();
            {
                for (int index = 0; index < videos.Count; index++)
                {
                    string title = videos[index].Title;
                    string id = videos[index].Id;
                    string url = videos[index].Url;
                    string thumbnail = "https://img.youtube.com/vi/" + id + "/0.jpg";

                    var video = await youtube.Videos.GetAsync(url);
                    string description = video.Description;

                    Items.Add(new Item() { Id = id, Title = title, Thumbnail = thumbnail, Description = description });
                }
            };
            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            
            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
