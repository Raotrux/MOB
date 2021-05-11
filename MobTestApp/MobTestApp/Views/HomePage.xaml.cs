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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

        }

        private async void DailyDose_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("DailyDosePage");
        }

        private async void ThreeMinMob_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ThreeMinMobPage");
        }

        private async void MyMob_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("MyMobPage");
        }

        private async void Settings_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("SettingsPage");
        }

        private async void Profile_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ProfilePage");
        }
    }
}