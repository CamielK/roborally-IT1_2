using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace roborally
{
	[Activity (Label = "Vriend toevoegen")]
	public class vriendtoevoegen : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.vriendtoevoegen);

			Button terug = FindViewById<Button> (Resource.Id.terug);
			Button vriend_toevoegen = FindViewById<Button> (Resource.Id.VriendToevoegen);

			terug.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
			vriend_toevoegen.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
		}
	}
}


