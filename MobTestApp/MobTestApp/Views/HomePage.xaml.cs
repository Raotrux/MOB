﻿using System;
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

        private async void Routines_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new RoutinesPage());
        }

        private async void MobLibrary_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new MobLibraryPage());
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