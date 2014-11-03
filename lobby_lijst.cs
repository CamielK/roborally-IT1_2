using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace roborally
{
	[Activity (Label = "Actieve lobbys")]
	public class lobby_lijst : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.lobby_lijst);

			Button terug = FindViewById<Button> (Resource.Id.terug);
			Button nieuwe_lobby = FindViewById<Button> (Resource.Id.nieuwe_lobby);
			Button lobby1 = FindViewById<Button> (Resource.Id.lobby1);
			Button lobby2 = FindViewById<Button> (Resource.Id.lobby2);
			Button lobby3 = FindViewById<Button> (Resource.Id.lobby3);
			Button lobby4 = FindViewById<Button> (Resource.Id.lobby4);
			Button lobby5 = FindViewById<Button> (Resource.Id.lobby5);

			terug.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
			nieuwe_lobby.Click += delegate {
				StartActivity(typeof(lobby_maken));
			};
			lobby1.Click += delegate {
				StartActivity(typeof(lobby));
			};
			lobby2.Click += delegate {
				StartActivity(typeof(lobby));
			};
			lobby3.Click += delegate {
				StartActivity(typeof(lobby));
			};
			lobby4.Click += delegate {
				StartActivity(typeof(lobby));
			};
			lobby5.Click += delegate {
				StartActivity(typeof(lobby));
			};
		}
	}
}


