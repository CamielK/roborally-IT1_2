using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace roborally
{
	[Activity (Label = "Vriendenlijst")]
	public class vriendenlijst : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.vriendenlijst);

			Button terug = FindViewById<Button> (Resource.Id.terug);
			Button vriend_toevoegen = FindViewById<Button> (Resource.Id.VriendToevoegen);
			Button vriend1 = FindViewById<Button> (Resource.Id.vriend1);

			terug.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
			//vriend_toevoegen.Click += delegate {
				//StartActivity(typeof(VriendToevoegen));
			//};
			//vriend1.Click += delegate {
				//StartActivity(typeof(vriend1));
			//};
		}
	}
}


