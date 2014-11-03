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
			Button vriend2 = FindViewById<Button> (Resource.Id.vriend2);
			Button vriend3 = FindViewById<Button> (Resource.Id.vriend3);
			Button vriend4 = FindViewById<Button> (Resource.Id.vriend4);
			Button vriend5 = FindViewById<Button> (Resource.Id.vriend5);

			terug.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
			vriend_toevoegen.Click += delegate {
				StartActivity(typeof(vriendtoevoegen));
			};
			vriend1.Click += delegate {
				StartActivity(typeof(vriend));
			};
			vriend2.Click += delegate {
				StartActivity(typeof(vriend));
			};
			vriend3.Click += delegate {
				StartActivity(typeof(vriend));
			};
			vriend4.Click += delegate {
				StartActivity(typeof(vriend));
			};
			vriend5.Click += delegate {
				StartActivity(typeof(vriend));
			};
		}
	}
}


