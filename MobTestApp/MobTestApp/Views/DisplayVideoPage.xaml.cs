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
    public partial class DisplayVideoPage : ContentPage
    {
        public DisplayVideoPage()
        {
            Device.SetFlags(new string[] { "MediaElement_Experimental" });
            InitializeComponent();
        }
    }
}