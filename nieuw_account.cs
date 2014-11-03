
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
	[Activity (Label = "Nieuw account maken")]			
	public class nieuw_account : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.nieuw_account);

			Button terug = FindViewById<Button> (Resource.Id.terug);
			Button aanmaken = FindViewById<Button> (Resource.Id.aanmaken);

			// button click gaat naar hoofdmenu
			terug.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
			aanmaken.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
		}
	}
}

