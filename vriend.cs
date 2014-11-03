using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace roborally
{
	[Activity (Label = "vriend #")]
	public class vriend : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.vriend);

			Button terug = FindViewById<Button> (Resource.Id.terug);

			terug.Click += delegate {
				StartActivity(typeof(vriendenlijst));
			};
		}
	}
}


