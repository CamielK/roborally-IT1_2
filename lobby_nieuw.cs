using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace roborally
{
	[Activity (Label = "lobby #")]
	public class lobby_nieuw : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.lobby_nieuw);

			Button terug = FindViewById<Button> (Resource.Id.terug);
			Button klaar = FindViewById<Button> (Resource.Id.starten);

			terug.Click += delegate {
				StartActivity(typeof(lobby_lijst));
			};
			klaar.Click += delegate {
				StartActivity(typeof(spel));
			};
		}
	}
}


