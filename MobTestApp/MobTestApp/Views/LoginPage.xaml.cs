using MobTestApp.ViewModels;
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.Navigation.PushAsync(new HomePage());
        }

        private async void InitOAuth(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new WebRedirectPage());
        }
    }
}