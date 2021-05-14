using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobTestApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMobPage : ContentPage
    {
        public MyMobPage()
        {
            InitializeComponent();
        }

        private async void MobMarket_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new MobMarketPage());
        }

        private async void MobPlaylist_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new MobPlaylistPage());
        }
    }
}