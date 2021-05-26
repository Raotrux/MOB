using MobTestApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobTestApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public Command ClickInit { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            ClickInit = new Command(InitOAuth);  //insert the beginning of the OAuth flow here.
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }

        private async void InitOAuth(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(OAuthRedirect)}");
        }
    }
}
