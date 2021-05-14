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
            await Shell.Current.Navigation.PushAsync(new DailyDosePage());
        }

        private async void ThreeMinMob_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new ThreeMinMobPage());
        }

        private async void MyMob_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new MyMobPage());
        }

        private async void Settings_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new SettingsPage());
        }
    }
}