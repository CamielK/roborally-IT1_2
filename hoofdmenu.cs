
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

	[Activity (Label = "Hoofdmenu")]			
	public class hoofdmenu : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Hoofdmenu);

			Button spelSpelen 	= FindViewById<Button> (Resource.Id.spel_spelen);
			Button bekijken 	= FindViewById<Button> (Resource.Id.spel_bekijken);
			Button button_vriendenlijst = FindViewById<Button> (Resource.Id.Vriendenlijst);
			Button button_feedback 		= FindViewById<Button> (Resource.Id.Feedback);
			Button button_uitloggen 	= FindViewById<Button> (Resource.Id.uitloggen);
			Button button_instellingen 	= FindViewById<Button> (Resource.Id.instellingen);
			Button button_info 			= FindViewById<Button> (Resource.Id.info);

			spelSpelen.Click += delegate {
				StartActivity(typeof(spel_spelen));
			};
			bekijken.Click += delegate {
				StartActivity(typeof(spel_bekijken));
			};
			button_vriendenlijst.Click += delegate {
				StartActivity(typeof(vriendenlijst));
			};
			button_feedback.Click += delegate {
				StartActivity(typeof(feedback));
			};
			button_uitloggen.Click += delegate {
				StartActivity(typeof(MainActivity));
			};
			button_instellingen.Click += delegate {
				StartActivity(typeof(instellingen));
			};
			button_info.Click += delegate {
				StartActivity(typeof(info));
			};
		}
	}
}

