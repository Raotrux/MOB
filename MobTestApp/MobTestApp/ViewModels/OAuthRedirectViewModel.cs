using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MobTestApp.ViewModels
{
    public class OAuthRedirectViewModel : BaseViewModel
    {
        public OAuthRedirectViewModel()
        {
            Title = "OAuthRedirect";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.github.com"));

        }

        public ICommand OpenWebCommand { get; }
    }
}