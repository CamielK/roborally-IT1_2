
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
	[Activity (Label = "spel bekijken")]			
	public class spel_bekijken : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.spel_bekijken);

			Button terug = FindViewById<Button> (Resource.Id.terug);
			Button spel = FindViewById<Button> (Resource.Id.Spel_joinen);
			Button lobby = FindViewById<Button> (Resource.Id.Lobby_joinen);

			terug.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
			spel.Click += delegate {
				StartActivity(typeof(spel_lijst));
			};
			lobby.Click += delegate {
				StartActivity(typeof(lobby_lijst_spectator));
			};
		}
	}
}

