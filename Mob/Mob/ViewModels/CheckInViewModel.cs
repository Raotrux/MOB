using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Mob.ViewModels
{
    public class CheckInViewModel : BaseViewModel
    {
        public CheckInViewModel()
        {
            Title = "1min Check In";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.github.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}