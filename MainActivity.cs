using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace roborally
{
	[Activity (Label = "Roborally IT1_2", MainLauncher = true, Icon = "@drawable/roborally_appicon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// koppel activity aan layout bestand
			SetContentView (Resource.Layout.Main);

			// button ophalen
			Button button = FindViewById<Button> (Resource.Id.myButton);
			Button nieuw_account = FindViewById<Button> (Resource.Id.accountmaken);
			Button wachtwoord_vergeten = FindViewById<Button> (Resource.Id.wachtwoordvergeten);

			// button click gaat naar hoofdmenu
			button.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
			nieuw_account.Click += delegate {
				StartActivity(typeof(nieuw_account));
			};
			wachtwoord_vergeten.Click += delegate {
				StartActivity(typeof(wachtwoord_vergeten));
			};
		}
	}
}


