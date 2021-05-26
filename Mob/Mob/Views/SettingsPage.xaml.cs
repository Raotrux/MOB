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
    public partial class SettingsPage : ContentPage
    {
        OSAppTheme currentTheme = Application.Current.RequestedTheme;
        public SettingsPage()
        {
            InitializeComponent();
            appTheme.Text = currentTheme.ToString();
        }


        private void ChangeTheme_Clicked(object sender, EventArgs e)
        {
            if (currentTheme.ToString() == "Light")
            {
                Application.Current.UserAppTheme = OSAppTheme.Dark;
            }

            if (currentTheme.ToString() == "Dark")
            {
                Application.Current.UserAppTheme = OSAppTheme.Dark;
            }
        }
    }
}