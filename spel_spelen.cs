
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace roborally
{
	[Activity (Label = "spel spelen")]			
	public class spel_spelen : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.spel_spelen);

			Button terug = FindViewById<Button> (Resource.Id.terug);
			Button nieuwe_lobby = FindViewById<Button> (Resource.Id.Lobby_maken);
			Button lobby = FindViewById<Button> (Resource.Id.Lobby_joinen);

			terug.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
			nieuwe_lobby.Click += delegate {
				StartActivity(typeof(lobby_maken));
			};
			lobby.Click += delegate {
				StartActivity(typeof(lobby_lijst));
			};
		}
	}
}

