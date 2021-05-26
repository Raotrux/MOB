using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Mob.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public ProfileViewModel()
        {
            Title = "Profile";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.github.com"));

        }

        public ICommand OpenWebCommand { get; }
    }
}