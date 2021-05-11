using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MobTestApp.ViewModels
{
    public class DisplayVideoViewModel : BaseViewModel
    {
        public DisplayVideoViewModel()
        {
            Title = "DisplayPage";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.github.com"));

        }

        public ICommand OpenWebCommand { get; }
    }
}