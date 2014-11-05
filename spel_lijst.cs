
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
	[Activity (Label = "spel lijst")]			
	public class spel_lijst : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.spel_lijst);

			Button terug = FindViewById<Button> (Resource.Id.terug);
			Button lobby1 = FindViewById<Button> (Resource.Id.lobby1);
			Button lobby2 = FindViewById<Button> (Resource.Id.lobby2);
			Button lobby3 = FindViewById<Button> (Resource.Id.lobby3);
			Button lobby4 = FindViewById<Button> (Resource.Id.lobby4);
			Button lobby5 = FindViewById<Button> (Resource.Id.lobby5);

			terug.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
			lobby1.Click += delegate {
				StartActivity(typeof(spel_spectator));
			};
			lobby2.Click += delegate {
				StartActivity(typeof(spel_spectator));
			};
			lobby3.Click += delegate {
				StartActivity(typeof(spel_spectator));
			};
			lobby4.Click += delegate {
				StartActivity(typeof(spel_spectator));
			};
			lobby5.Click += delegate {
				StartActivity(typeof(spel_spectator));
			};
		}
	}
}

