using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Identity.Client;
using Xamarin.Forms;

namespace App1
{
	public partial class App : Application
	{
	    public static PublicClientApplication PCA = null;
	    public static string ClientID = "60f51830-d4c8-4680-92ff-5ca33a826dd7";
	    public static string[] Scopes = { "User.Read" };
	    public static string Username = string.Empty;

	    public static UIParent UiParent = null;
        public App ()
		{
			InitializeComponent();
		    // default redirectURI; each platform specific project will have to override it with its own
		    PCA = new PublicClientApplication(ClientID);
            MainPage = new App1.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
