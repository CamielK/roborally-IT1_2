
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
	[Activity (Label = "wachtwoord vergeten")]			
	public class wachtwoord_vergeten : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.wachtwoord_vergeten);

			Button terug = FindViewById<Button> (Resource.Id.terug);
			Button opvragen = FindViewById<Button> (Resource.Id.opvragen);

			// button click gaat naar hoofdmenu
			terug.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
			opvragen.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
		}
	}
}

