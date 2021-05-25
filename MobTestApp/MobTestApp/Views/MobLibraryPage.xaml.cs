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
    public partial class MobLibraryPage : ContentPage
    {
        public MobLibraryPage()
        {
            InitializeComponent();
        }

        private async void Singles_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new SinglesPage());
        }

        private async void MobMarket_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new MobMarketPage());
        }
    }
}