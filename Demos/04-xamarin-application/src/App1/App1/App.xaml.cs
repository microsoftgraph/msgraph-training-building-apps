using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.Identity.Client;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App1
{
    public partial class App : Application
    {
        public static PublicClientApplication PCA = null;
        public static string ClientID = "YOUR_CLIENT_ID";
        public static string[] Scopes = { "User.Read" };
        public static string Username = string.Empty;

        public static UIParent UiParent = null;
        public App()
        {
            InitializeComponent();
            PCA = new PublicClientApplication(ClientID);
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
