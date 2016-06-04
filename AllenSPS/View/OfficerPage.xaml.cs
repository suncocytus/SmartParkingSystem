using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AllenSPS
{
	public partial class OfficerPage : ContentPage
	{
		public OfficerPage ()
		{
			InitializeComponent ();
		}
		private async void NotificationButton_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ViolationParkingNotification());
		}
	}
}

