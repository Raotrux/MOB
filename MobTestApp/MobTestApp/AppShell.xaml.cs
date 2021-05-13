using MobTestApp.ViewModels;
using MobTestApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MobTestApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //These two were created by the Shell code
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));


            //Buttons on Home Page
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(DailyDosePage), typeof(DailyDosePage));
            Routing.RegisterRoute(nameof(ThreeMinMobPage), typeof(ThreeMinMobPage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
            Routing.RegisterRoute(nameof(MyMobPage), typeof(MyMobPage));

            //Buttons inside Settings Page
            Routing.RegisterRoute(nameof(ApplicationPage), typeof(ApplicationPage));
            Routing.RegisterRoute(nameof(BillingPage), typeof(BillingPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(PremiumPage), typeof(PremiumPage));

            //Buttons inside the My Mob Page
            Routing.RegisterRoute(nameof(MobMarketPage), typeof(MobMarketPage));
            Routing.RegisterRoute(nameof(MobPlaylistPage), typeof(MobPlaylistPage));


            //Basic Video page
            Routing.RegisterRoute(nameof(TemplateVideoPage), typeof(TemplateVideoPage));
            
            
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
