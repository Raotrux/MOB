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
            InitializeComponent();
            webview.Source = "https://www.youtube.com/watch?v=hY7m5jjJ9mM";
            //var localhtml = new HtmlWebViewSource();
            //localhtml.Html = @"<html><body>
            //                        <h1>Xamarin Webview</h1>
            //                        <p>This is a test of the webviewsource</p>
            //                </body></html>";
            //webview.Source = localhtml;
        }
    }
}