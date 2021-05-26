using System;
using System.Collections.Generic;
using MobTestApp.Models;
using MobTestApp.ViewModels;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace MobTestApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OAuthRedirectPage : ContentPage
    {
        public OAuthRedirectPage()
        {
            InitializeComponent();
            Binding = this;
            myLabel.Text = "OAUTH";
        }

    }
}