
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

	[Activity (Label = "Info")]			
	public class info : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.info);

			Button terug 	= FindViewById<Button> (Resource.Id.terug);

			terug.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
		}
	}
}

