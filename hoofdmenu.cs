
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

	[Activity (Label = "Hoofdmenu")]			
	public class hoofdmenu : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Hoofdmenu);

			Button button_lobbyjoinen 	= FindViewById<Button> (Resource.Id.Lobby_joinen);
			Button button_lobbymaken 	= FindViewById<Button> (Resource.Id.Lobby_maken);
			Button button_vriendenlijst = FindViewById<Button> (Resource.Id.Vriendenlijst);
			Button button_feedback 		= FindViewById<Button> (Resource.Id.Feedback);
			Button button_uitloggen 	= FindViewById<Button> (Resource.Id.uitloggen);
			Button button_instellingen 	= FindViewById<Button> (Resource.Id.instellingen);

			//button_lobbyjoinen.Click += delegate {
				//StartActivity(typeof(lobby_lijst));
			//};
			//button_lobbymaken.Click += delegate {
				//StartActivity(typeof(new_lobby));
			//};
			//button_vriendenlijst.Click += delegate {
				//StartActivity(typeof(vriendenlijst));
			//};
			button_feedback.Click += delegate {
				StartActivity(typeof(feedback));
			};
			button_uitloggen.Click += delegate {
				StartActivity(typeof(MainActivity));
			};
			button_instellingen.Click += delegate {
				StartActivity(typeof(instellingen));
			};
		}
	}
}

