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
    public partial class RoutinesPage : ContentPage
    {
        public RoutinesPage()
        {
            InitializeComponent();
        }

        private async void CheckIn_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new CheckInPage());
        }

        private async void ThreeMinMob_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new ThreeMinMobPage());
        }

        private async void ListView_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new ListViewPage());
        }
    }
}