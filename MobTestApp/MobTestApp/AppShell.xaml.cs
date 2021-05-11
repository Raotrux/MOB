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
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(DailyDosePage), typeof(DailyDosePage));
            Routing.RegisterRoute(nameof(ThreeMinMobPage), typeof(ThreeMinMobPage));
            Routing.RegisterRoute(nameof(MobMarketPage), typeof(MobMarketPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
            Routing.RegisterRoute(nameof(TemplateVideoPage), typeof(TemplateVideoPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
