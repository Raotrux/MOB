using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MobTestApp.ViewModels
{
    public class RoutinesViewModel : BaseViewModel
    {
        public RoutinesViewModel()
        {
            Title = "Routines";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.github.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}