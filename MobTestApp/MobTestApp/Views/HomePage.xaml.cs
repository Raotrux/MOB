using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobTestApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        OAuth2Authenticator Authenticator;
        public HomePage()
        {
            InitializeComponent();
        }
        public HomePage(OAuth2Authenticator authenticator)
        {
            InitializeComponent();
            Authenticator = authenticator;
        }

        private async void DailyDose_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new DailyDosePage());
        }

        private async void MobLibrary_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new TabbedRoutinesLibrary());
        }

        private async void Settings_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new SettingsPage());
        }

        private async void About_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new AboutPage());
        }
    }
}