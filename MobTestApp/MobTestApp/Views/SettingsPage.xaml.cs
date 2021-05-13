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
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private async void ApplicationPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ApplicationPage");
        }

        private async void ProfilePage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ProfilePage");
        }
        private async void BillingPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("BillingPage");
        }
        private async void PremiumPage_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("PremiumPage");
        }
    }
}