using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace AllenSPS
{
	public partial class Final_UserPage : ContentPage
	{
		public Final_UserPage ()
		{
			InitializeComponent ();
		}
		async void PushButton_Onclicked (object sender, EventArgs e)
		{
			var action = await DisplayActionSheet ("Your booking information: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
			Debug.WriteLine ("Action: " + action);
		}
	}
}

