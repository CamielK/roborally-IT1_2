﻿
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
	[Activity (Label = "hoofdmenu")]			
	public class hoofdmenu : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Hoofdmenu);

			Button button = FindViewById<Button> (Resource.Id.uitloggen);

			button.Click += delegate {
				StartActivity(typeof(MainActivity));
			};
		}
	}
}

