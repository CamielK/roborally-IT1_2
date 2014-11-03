
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
	[Activity (Label = "nieuwe lobby maken")]			
	public class lobby_maken : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.lobby_maken);

			Button button_maken	= FindViewById<Button> (Resource.Id.maken);
			Button button_terug	= FindViewById<Button> (Resource.Id.terug);

			button_terug.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
			button_maken.Click += delegate {
				StartActivity(typeof(lobby_nieuw));
			};
		}
	}
}

