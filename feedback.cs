
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
	[Activity (Label = "Feedback geven")]			
	public class feedback : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.feedback);

			Button button_verzenden	= FindViewById<Button> (Resource.Id.verzenden);

			button_verzenden.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
		}
	}
}

