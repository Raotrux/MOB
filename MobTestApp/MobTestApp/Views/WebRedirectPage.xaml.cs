using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobTestApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebRedirectPage : ContentPage
    {
        int AUTH_TYPE;
        public WebRedirectPage(int authType)
        {
            InitializeComponent();
            BindingContext = this;
            AUTH_TYPE = authType;
            OAuth_Google();
        }

        public OAuth2Authenticator Authenticator { get; private set; }

        protected async void OAuth_Google()
        {
            if (AUTH_TYPE == 1)
            {
                
                
                Authenticator = new Xamarin.Auth.OAuth2Authenticator
                    (
                        clientId:
                            new Func<string>
                               (
                                   () =>
                                   {
                                       string retval_client_id = "oops something is wrong!";

                                    // some people are sending the same AppID for google and other providers
                                    // not sure, but google (and others) might check AppID for Native/Installed apps
                                    // Android and iOS against UserAgent in request from 
                                    // CustomTabs and SFSafariViewContorller
                                    // TODO: send deliberately wrong AppID and note behaviour for the future
                                    // fitbit does not care - server side setup is quite liberal
                                    switch (Xamarin.Forms.Device.RuntimePlatform)
                                       {
                                           case "Android":
                                               retval_client_id = "71145666052-5hfmdjv4d3evo67sjq2ea9fq5cngi5qb.apps.googleusercontent.com";
                                               break;
                                           case "iOS":
                                               retval_client_id = "71145666052-kecq6ukpask9r6m7irorb3hqlmlti7cq.apps.googleusercontent.com";
                                               break;
                                       }
                                       return retval_client_id;
                                   }
                              ).Invoke(),
                       clientSecret: null,   // null or ""
                       authorizeUrl: new Uri("https://accounts.google.com/o/oauth2/auth"),
                       accessTokenUrl: new Uri("https://www.googleapis.com/oauth2/v4/token"),
                       redirectUrl:
                           new Func<Uri>
                               (
                                   () =>
                                   {

                                       string uri = null;

                                    // some people are sending the same AppID for google and other providers
                                    // not sure, but google (and others) might check AppID for Native/Installed apps
                                    // Android and iOS against UserAgent in request from 
                                    // CustomTabs and SFSafariViewContorller
                                    // TODO: send deliberately wrong AppID and note behaviour for the future
                                    // fitbit does not care - server side setup is quite liberal
                                    switch (Xamarin.Forms.Device.RuntimePlatform)
                                       {
                                           case "Android":
                                               uri =
                                                   "com.googleusercontent.apps.71145666052-5hfmdjv4d3evo67sjq2ea9fq5cngi5qb:/oauth2redirect"
                                                   //"com.googleusercontent.apps.1093596514437-d3rpjj7clslhdg3uv365qpodsl5tq4fn:/oauth2redirect"
                                                   ;
                                               break;
                                           case "iOS":
                                               uri =
                                                   "com.googleusercontent.apps.71145666052-kecq6ukpask9r6m7irorb3hqlmlti7cq:/oauth2redirect"
                                                   //"com.googleusercontent.apps.1093596514437-cajdhnien8cpenof8rrdlphdrboo56jh:/oauth2redirect"
                                                   ;
                                               break;
 
                                       }

                                       return new Uri(uri);
                                   }
                                ).Invoke(),
                        scope:
                                     //"profile"
                                     "https://www.googleapis.com/auth/userinfo.profile https://www.googleapis.com/auth/userinfo.email https://www.googleapis.com/auth/plus.login"
                                     ,
                        getUsernameAsync: null
                    )
                {
                    AllowCancel = true,
                };

                Authenticator.Completed +=
                    (s, ea) =>
                    {
                        StringBuilder sb = new StringBuilder();

                        if (ea.Account != null && ea.Account.Properties != null)
                        {
                            sb.Append("Token = ").AppendLine($"{ea.Account.Properties["access_token"]}");
                        }
                        else
                        {
                            sb.Append("Not authenticated ").AppendLine($"Account.Properties does not exist");
                        }

                        DisplayAlert
                                (
                                    "Authentication Results",
                                    sb.ToString(),
                                    "OK"
                                );

                        return;
                    };

                Authenticator.Error +=
                    (s, ea) =>
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append("Error = ").AppendLine($"{ea.Message}");

                        DisplayAlert
                                (
                                    "Authentication Error",
                                    sb.ToString(),
                                    "OK"
                                );
                        return;
                    };

                // after initialization (creation and event subscribing) exposing local object 
                AuthenticationState.Authenticator = Authenticator;

                await Browser.OpenAsync(Authenticator.AuthorizeUrl, BrowserLaunchMode.SystemPreferred);
                //await Shell.Current.Navigation.PushAsync(new HomePage(Authenticator));

                return;
            }
        }
    }
}