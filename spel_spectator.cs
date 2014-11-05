using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace roborally
{
	[Activity (Label = "Actief spel")]
	public class spel_spectator : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.spel_spectator);

			Button terug = FindViewById<Button> (Resource.Id.stoppen);

			terug.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
		}
	}
}
