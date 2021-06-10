using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class uiView : ContentPage
    {
        public uiView()
        {
            InitializeComponent();
        }

        private async void Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("*Click*", "The Button was clicked", "Super");
        }
    }
}