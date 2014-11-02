using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace roborally
{
	[Activity (Label = "Instellingen")]
	public class instellingen : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// koppel activity aan layout bestand
			SetContentView (Resource.Layout.instellingen);

			// button ophalen
			Button terug = FindViewById<Button> (Resource.Id.terug);

			// button click gaat naar hoofdmenu
			terug.Click += delegate {
				StartActivity(typeof(hoofdmenu));
			};
		}
	}
}


