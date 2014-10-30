using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace roborally
{
	[Activity (Label = "roborally", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// koppel activity aan layout bestand
			SetContentView (Resource.Layout.Main);

			// button ophalen
			Button button = FindViewById<Button> (Resource.Id.myButton);

			// button click gaat naar hoofdmenu
			button.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
		}
	}
}


