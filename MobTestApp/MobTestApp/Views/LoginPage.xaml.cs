using MobTestApp.ViewModels;
using System;
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
            await Shell.Current.Navigation.PushAsync(new HomePage());
        }

        private async void InitOAuth(object sender, EventArgs e)
        {
            var authType = 1;
            await Shell.Current.Navigation.PushAsync(new WebRedirectPage(authType));
        }
    }
}