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

        private async void Settings1_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Settings1");
        }

        private async void Settings2_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Settings2");
        }
    }
}